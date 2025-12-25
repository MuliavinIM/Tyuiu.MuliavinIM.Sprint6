using Tyuiu.MuliavinIM.Sprint6.Task7.V16.Lib;
namespace Tyuiu.MuliavinIM.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_MIM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_MIM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_MIM_Click(object sender, EventArgs e)
        {
            openFileDialog_MIM.ShowDialog();
            openFile = openFileDialog_MIM.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPutData_MIM.RowCount = rows;
            dataGridViewInPutData_MIM.ColumnCount = columns;
            dataGridViewOutPutData_MIM.RowCount = rows;
            dataGridViewOutPutData_MIM.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_MIM.Columns[i].Width = 50;
                dataGridViewOutPutData_MIM.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_MIM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_MIM.Enabled = true;
        }

        private void buttonOpenFile_MIM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MIM.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MIM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MIM.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MIM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MIM.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_MIM_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MIM.ToolTipTitle = "Справка";
        }

        private void buttonHelp_MIM_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }

        private void buttonSave_MIM_Click(object sender, EventArgs e)
        {
            saveFileDialog_MIM.FileName = "OutPutFileTask7.csv";
            saveFileDialog_MIM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MIM.ShowDialog();

            string path = saveFileDialog_MIM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_MIM.RowCount;
            int columns = dataGridViewOutPutData_MIM.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPutData_MIM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPutData_MIM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPutData_MIM.RowCount = 50;
            dataGridViewOutPutData_MIM.RowCount = 50;

            dataGridViewInPutData_MIM.ColumnCount = 50;
            dataGridViewOutPutData_MIM.ColumnCount = 50;

            panelLeft_MIM.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPutData_MIM.Columns[i].Width = 25;
                dataGridViewOutPutData_MIM.Columns[i].Width = 25;
            }
        }

        private void buttonDone_MIM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_MIM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_MIM.Enabled = true;
        }

        private void textBoxTask_MIM_TextChanged(object sender, EventArgs e)
        {
                    
        }
        
    }
}