using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_WPF
{
    public static class FileWork
    {
        public static void SaveToFile(List<String> vs)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            String fileName = saveFileDialog.FileName;

            String data = "";
            for (int i = 0; i < vs.Count(); ++i)
            {
                data += vs[i] + "\n";
            }
            System.IO.File.WriteAllText(fileName, data);

            MessageBox.Show("File saved");
        }
    }
}
