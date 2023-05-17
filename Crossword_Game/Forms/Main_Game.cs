using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crossword_Game
{
    public partial class Main_Game : Form
    {
        Hints hint_window = new Hints();

        List<id_cells> list = new List<id_cells>();
        public string qfile = Application.StartupPath + "\\Questions\\Questions1.txt";
        

        public Main_Game()
        {
            buildWordList();
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: Иванов Алексей, ИП-20-7к", "Помощи нет");
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeBoard();
            hint_window.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
            hint_window.StartPosition = FormStartPosition.Manual;

            hint_window.Show();
            hint_window.hint_table.AutoResizeColumns();
        }

        private void InitializeBoard() 
        {
            board.BackgroundColor = Color.Black;
            board.DefaultCellStyle.BackColor = Color.Black;

            for (int i = 0; i < 20; i++)
                board.Rows.Add();

            //Установка ширины колонок
            foreach (DataGridViewColumn c in board.Columns)
                c.Width = board.Width / board.Columns.Count;

            //Установка ширины рядов
            foreach (DataGridViewRow r in board.Rows)
                r.Height = board.Height / board.Rows.Count;

            //Только чтение для всех ячеек
            for (int row =0; row < board.Rows.Count; row++)
            {
                for (int col = 0; col < board.Columns.Count; col++)
                    board[col, row].ReadOnly = true;
            }

            foreach(id_cells i in list)
            {
                int start_column = i.X;
                int start_row = i.Y;
                char[] word = i.word.ToCharArray();

                for (int j = 0; j < word.Length; j++)
                {
                    if (i.direction.ToLower() == "по горизонтали")
                        formatCell(start_row, start_column + j, word[j].ToString());

                    if (i.direction.ToLower() == "по вертикали")
                        formatCell(start_row + j, start_column, word[j].ToString());
                }
            }

        }

        private void formatCell(int row, int col, String letter)
        {
            DataGridViewCell c = board[col, row];
            c.Style.BackColor = Color.White;
            c.ReadOnly = false;
            c.Style.SelectionBackColor = Color.LightSkyBlue;
            c.Tag = letter;
        }


        private void Main_Game_LocationChanged(object sender, EventArgs e)
        {
        hint_window.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
         }

        public void buildWordList()
        {
            string line = "";
            using (StreamReader s = new StreamReader(qfile))
            {
                line = s.ReadLine();
                while((line = s.ReadLine()) != null)
                {
                    string[] l = line.Split('/');
                    list.Add(new id_cells(int.Parse(l[0]), int.Parse(l[1]), l[2], l[3], l[4], l[5]));
                    hint_window.hint_table.Rows.Add(new string[] { l[3], l[2], l[5] });
                }
            }
        }

        private void board_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                board[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].Value.ToString().ToLower();

            } catch { }

            try
            {
                if (board[e.ColumnIndex, e.RowIndex].Value.ToString().Length > 1)
                    board[e.ColumnIndex, e.RowIndex].Value = board[e.ColumnIndex, e.RowIndex].Value.ToString().Substring(0,1);
            }
            catch { }

            try
            {
                if (board[e.ColumnIndex, e.RowIndex].Value.ToString().ToLower().Equals(board[e.ColumnIndex, e.RowIndex].Tag.ToString().ToLower()))
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.LightSeaGreen;
                else
                    board[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Crimson;

            }
            catch { }
        }

        private void открытьКроссвордToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Crossword 17|*.txt";
            if (file.ShowDialog().Equals(DialogResult.OK))
            {
                qfile = file.FileName;
                board.Rows.Clear();
                hint_window.hint_table.Rows.Clear();
                list.Clear();

                buildWordList();
                InitializeBoard();
            }
        }
    }

    public class id_cells
    {
        public int X;
        public int Y;
        public string direction;
        public string number;
        public string word;
        public string hint;

        public id_cells(int x, int y, string d, string n, string w, string h )
        {
            this.X = x;
            this.Y = y;
            this.direction = d;
            this.number = n;
            this.word = w;
            this.hint = h;
        }
    }
}
