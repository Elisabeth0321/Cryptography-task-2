using System;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class MyForm: Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void bttnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                uint seed = Convert.ToUInt32(txtbxKey.Text, 2);
                StreamCipher streamCipher = new StreamCipher(seed);

                byte[] fileBytes = Utils.BinaryToBytes(txtbxOriginalBinary.Text);
                byte[] encryptedBytes = streamCipher.Encode(fileBytes);

                txtbxGeneratedKey.Text = Utils.BytesToBinary(streamCipher.KeyStream);
                txtbxResultBinary.Text = Utils.BytesToBinary(encryptedBytes);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Некорректный ключ! Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                    txtbxOriginalBinary.Text = Utils.BytesToBinary(fileBytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] fileBytes = Utils.BinaryToBytes(txtbxResultBinary.Text);
                    File.WriteAllBytes(saveFileDialog.FileName, fileBytes);
                    MessageBox.Show("Файл успешно сохранён.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        private void txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
