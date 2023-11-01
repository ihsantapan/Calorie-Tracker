using Program.DAL.Repositories;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI
{
    public partial class HistoryPage : Form
    {
        public HistoryPage(AppUser user)
        {
            User = user;
            InitializeComponent();
        }
        AppUser User;
        List<DateTime> dates = new List<DateTime>();
        UsersMealsHistoryRepository histrep = new();
        private void HistoryPage_Load(object sender, EventArgs e)
        {
            dates = histrep.GetAllDatesOfUser(User);
            string[] arr = new string[2];
            foreach (DateTime dt in dates)
            {
                arr[0] = dt.ToShortDateString();
                arr[1] = histrep.TotalCalorieOfDay(User, dt).ToString();
                ListViewItem lvi = new ListViewItem(arr);
                lvDays.Items.Add(lvi);
            }
        }
        DateTime SelectedDate = new();
        NutritionRepository nutrep = new NutritionRepository();
        CategoryRepository catrep = new CategoryRepository();

        private void lvDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            histrep = new UsersMealsHistoryRepository();
            if (lvDays.SelectedItems.Count > 0)
            {
                lvMeals.Items.Clear();
                SelectedDate = Convert.ToDateTime(lvDays.SelectedItems[0].Text);
                int counter = 0;
                foreach (Meal meal in histrep.GetAllMealsOfDay(SelectedDate.Date, User))
                {
                    string[] arr = { string.Empty, meal.MealName, string.Empty, string.Empty, string.Empty, histrep.GetMealCalorie(User, meal, SelectedDate).ToString(), string.Empty };
                    ListViewItem lvi = new ListViewItem(arr);
                    lvi.Font = new Font(Font, FontStyle.Bold);
                    lvMeals.Items.Add(lvi);
                    lvi.Tag = meal;
                    counter = 0;
                    foreach (UsersMealsHistory item in histrep.GetDaysUserMealHistoryOfMeal(meal.ID, SelectedDate,User))
                    {
                        Nutrition nutrition = new Nutrition();
                        nutrition = nutrep.GetNutritionByID(item.NutritionID);
                        counter++;
                        string[] arr2 = { counter.ToString(), nutrition.Name, catrep.GetCategoryById(nutrition.CategoryID).CategoryName, nutrition.Calorie.ToString(), item.NumberOfNutritions.ToString(), (nutrition.Calorie * item.NumberOfNutritions).ToString(), nutrition.Measurement + " " + nutrition.PortionType.ToString() };
                        ListViewItem lvi2 = new ListViewItem(arr2);
                        lvMeals.Items.Add(lvi2);
                        lvi2.Tag = item;
                    }
                }
            }
        }
        MealRepository mealrep;
        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            foreach (UsersMealsHistory item in histrep.GetDaysUserMealHistoryOfMeal(SelectedMeal.ID, SelectedDate.Date,User))
            {
                histrep.Delete(item);
            }
        }
        Meal SelectedMeal;
        private void lvMeals_Click(object sender, EventArgs e)
        {
            if (lvMeals.SelectedItems.Count > 0)
            {
                try
                {
                    SelectedMeal = (Meal)lvMeals.SelectedItems[0].Tag;
                }
                catch (Exception)
                {
                    SelectedMeal = null;
                    throw;
                }
            }
        }
    }
}
