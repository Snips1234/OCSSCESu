using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace OCSSCESu.helper
{
    public class PublicHelper
    {

        // Display data to Data grid

        private static readonly object GdiLock = new object();
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image));

            // Clone the image to avoid disposal issues
            using (Image clonedImage = new Bitmap(image))
            using (MemoryStream ms = new MemoryStream())
            {
                // Use a lock for thread safety (if needed)
                lock (GdiLock)
                {
                    clonedImage.Save(ms, format);
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    return Image.FromStream(ms, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting Base64 to Image: {ex.Message}");
                return null;
            }
        }

        public static System.Drawing.Imaging.ImageFormat GetImageFormat(string filename)
        {
            string extension = Path.GetExtension(filename).ToLower();
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ".png":
                    return System.Drawing.Imaging.ImageFormat.Png;
                case ".bmp":
                    return System.Drawing.Imaging.ImageFormat.Bmp;
                default:
                    throw new NotSupportedException("File format not supported");
            }
        
        }

        public static ImageFormat GetImageFormat_2(Image image)
        {
            if (image.RawFormat.Equals(ImageFormat.Jpeg))
                return ImageFormat.Jpeg;
            if (image.RawFormat.Equals(ImageFormat.Png))
                return ImageFormat.Png;
            if (image.RawFormat.Equals(ImageFormat.Bmp))
                return ImageFormat.Bmp;
            if (image.RawFormat.Equals(ImageFormat.Gif))
                return ImageFormat.Gif;
            if (image.RawFormat.Equals(ImageFormat.Tiff))
                return ImageFormat.Tiff;

          
            return ImageFormat.Png; 
        }

        public static void DisplayData(Guna2DataGridView dataGridView, DataTable dataSource, List<String> columnNames)
        { 
            try
            {
                if (dataSource != null && dataSource.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataSource;

                    if (columnNames != null && columnNames.Count == dataSource.Columns.Count)
                    {

                        int columnIndex = 0;

                        foreach (DataColumn column in dataSource.Columns)
                        {
                            dataGridView.Columns[column.ColumnName].HeaderText = columnNames[columnIndex];

                            columnIndex++;
                        }
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Column names list does not match the number of columns in the DataTable.", "COLUMN COUNT NOT MATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //else
                //{
                //    SystemSounds.Asterisk.Play();
                //    MessageBox.Show("No data found.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                
            }
            catch (Exception ex) 
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error occur while displaying data. Error: {ex.Message}", "DATA FAILED TO DISPLAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearControls(Form frm)
        {
            try
            {
               ClearControlRecursive(frm);
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"An error occur while clear controls. Error: {ex}", "CONTROLS FAILED TO CLEAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ClearControlRecursive(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)ctrl;
                    textBox.Clear();
                }
                else if (ctrl is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }
                else if (control is Guna2DateTimePicker)
                {
                    Guna2DateTimePicker dateTimePicker = (Guna2DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Today.Date;
                }
                else if (control is Guna2NumericUpDown)
                {
                    Guna2NumericUpDown numeric = (Guna2NumericUpDown)control;
                    numeric.Value = 0;
                }

                if (ctrl.HasChildren)
                {
                    ClearControlRecursive(ctrl);
                }
                
            }
        }


        //public  Boolean ValidateControls(Form frm, List<String> exceptionControl = null)
        //{
        //    bool isValid = true;

        //    foreach (Control control in frm.Controls)
        //    {
        //        if (exceptionControl != null && exceptionControl.Contains(control.Name))
        //        {
        //            continue;
        //        }

        //        if (control is Guna2TextBox)
        //        {
        //            Guna2TextBox txt = (Guna2TextBox)control;
        //            if (String.IsNullOrEmpty(txt.Text))
        //            {
        //                isValid = false;
        //                break;
        //            }

        //        }
        //        else if (control is Guna2ComboBox)
        //        {
        //            Guna2ComboBox comboBox = (Guna2ComboBox)control;
        //            if (comboBox.SelectedIndex == -1)
        //            {
        //                isValid = false;
        //                break;
        //            }
        //        }
        //        else if (control is Guna2DateTimePicker)
        //        {
        //            Guna2DateTimePicker dateTimePicker = (Guna2DateTimePicker)control;
        //            if (dateTimePicker.Value.Date == DateTime.Today.Date)
        //            {
        //                isValid = false;
        //                break;
        //            }
        //        }
        //        else if (control is Guna2NumericUpDown)
        //        {

        //            Guna2NumericUpDown numeric = (Guna2NumericUpDown)control;
        //            if (numeric.Value == 0)
        //            {
        //                isValid = false;
        //                break;
        //            }
        //        }
        //    }

        //    return isValid;


        //}

        public bool ValidateControls(Form frm, List<string> exceptionControl = null)
        {
            var exceptionSet = exceptionControl != null
                ? new HashSet<string>(exceptionControl, StringComparer.OrdinalIgnoreCase)
                : null;

            foreach (Control control in frm.Controls)
            {
                if (exceptionSet?.Contains(control.Name) == true)
                {
                    continue;
                }

                switch (control)
                {
                    case Guna2TextBox txt when string.IsNullOrEmpty(txt.Text):
                    case Guna2ComboBox combo when combo.SelectedIndex == -1:
                    case Guna2DateTimePicker dtp when dtp.Value.Date == DateTime.Today.Date:
                    case Guna2NumericUpDown num when num.Value == 0:
                        return false; 
                }
            }

            return true;
        }

        public static void DisplayChildForm(Guna2Panel panel, Form childForm)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                MessageBox.Show("The form is not valid or has been disposed.", "INVALID FORM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            childForm.TopMost = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(childForm);
            childForm.Show();

        }

       

    }
    //Styling class
    public class Styling
    {


        public static void DataGridViewStyle(Guna2DataGridView dataGrid) 
        {
            Guna2Elipse elipse = new Guna2Elipse();

            //elipse.BorderRadius = 20;
            //elipse.TargetControl = dataGrid;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(64,0,0);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255,255,255);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.RowsDefaultCellStyle.Font = new Font("Segeo UI", 12, FontStyle.Regular);
            dataGrid.RowTemplate.Height = 30;
            dataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(64, 0, 0);
            dataGrid.ThemeStyle.HeaderStyle.Height = 50;

        }
    }
}
