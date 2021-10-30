using MetricSuite.store_operations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    class FileOperations
    {
        public void writeToFile(DataStore ds)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "txt files |*.ms";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.

                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(myStream, ds);

                    myStream.Close();
                }
            }
        }


        public DataStore readFromFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            DataStore ds = new DataStore();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Filter = "txt files |*.ms";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                // De-Serialize
                IFormatter formatter = new BinaryFormatter();

                 ds = (DataStore)formatter.Deserialize(fileStream);
            }

            return ds;
        }
    }
}
