using BrazilianECommerceApp;
using System;
using System.Data;
using System.Data.SqlClient; // رجعناها صح عشان الـ SQL يشتغل
using System.Windows.Forms;

namespace BrazilianEcommerceApp
{
    public partial class Form1 : Form
    {
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            WireEvents();
        }

        private void WireEvents()
        {
            // ربط الزراير بالأحداث الخاصة بها
            btnClientLoad.Click += BtnClientLoad_Click;
            btnClientSearch.Click += BtnClientSearch_Click;
        }

        // 1. كود عرض البيانات (Load)
        private void BtnClientLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // غيرنا CLIENT لـ olist_customers_dataset واستخدمنا TOP 100 للسرعة
                string query = "SELECT TOP 100 * FROM olist_customers_dataset";
                DataTable dt = dbHelper.ExecuteDataTable(query);
                dgvClient.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في عرض البيانات: " + ex.Message);
            }
        }

        // 2. كود البحث (Search)
        private void BtnClientSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("Please enter a Customer ID to search.", "Validation");
                return;
            }

            try
            {
                // غيرنا اسم الجدول والعمود للأسماء الصح في الداتا سيت
                string query = "SELECT * FROM olist_customers_dataset WHERE customer_id = @Id";
                SqlParameter[] parameters = { new SqlParameter("@Id", txtClientId.Text) };
                DataTable dt = dbHelper.ExecuteDataTable(query, parameters);
                dgvClient.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في البحث: " + ex.Message);
            }
        }
    }
}