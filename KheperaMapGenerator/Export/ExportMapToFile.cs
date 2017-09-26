using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KheperaMapGenerator.Export
{
    class ExportMapToFile
    {
        public void ExportMap(PictureBox map)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            try
            {
                saveFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    map.Image.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Plik został zapisany.");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Plik nie został zapisany!");
            }
        }
    }
}
