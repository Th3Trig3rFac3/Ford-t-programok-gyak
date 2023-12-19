using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;

namespace AXAF1W_Beadando

//grafwiz csomag szintaxisfához
{
    public partial class mainForm : Form
    {
        internal static int index = 0;
        internal static Stack<string> stack = new Stack<string>();
        internal static string numberOfMetszetSzam = "";
        internal static List<string> outPutList = new List<string>();
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //tableInputButton
        {
            tableInputForm tableInputForm = new tableInputForm();
            tableInputForm.Show();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            stack.Clear();
            stack.Push("#");
            index = 0;
            numberOfMetszetSzam = "";
            outPutList.Clear();
            if (stackInputTB.Text.Length > 1)
                stackInputTB.Text = "Only 1 characher is accepted";
            if (stackInputTB.Text.Length == 1)
                stack.Push(stackInputTB.Text);
            if (inputStripTB.Text == string.Empty)
                inputStripErr.Text = "Input cannot be empty";
            if (inputStripTB.Text != string.Empty)
                inputStripErr.Text = "";
            if (tableInputForm.tableData is null)
            {
                stack.Push(stackInputTB.Text);
            }
            if (tableInputForm.tableData is not null)
            {
                if (stackInputTB.Text == string.Empty && !tableInputForm.tableData[1][0].Any(char.IsDigit))
                    stack.Push(tableInputForm.tableData[1][0]);
            }
            if (inputStripTB.Text is not null && tableInputForm.tableData is not null)
            {
                compute();
                Output output = new Output(outPutList);
                output.Show();
            }

        }
        private void compute()
        {
            StringBuilder sb = new StringBuilder();
            string input = inputStripTB.Text;
            input = ReplaceNumbers(input, "i");
            input += '#';
            bool isDone = false;
            //Úgy kell keresni, hogy az első oszlopban és sorban vannak az elemeket, amik alapján keresünk később
            List<string> sor = new List<string>();
            List<string> oszlop = new List<string>();
            for (int i = 0; i < tableInputForm.rowCount; i++) //Ezek a táblázatban szereplő oszlopok és sorok elemei
            {
                if (tableInputForm.tableData[i][0] is not null)
                    sor.Add(tableInputForm.tableData[i][0]);
            }
            for (int i = 0; i < tableInputForm.columnCount; i++)
            {
                if (tableInputForm.tableData[0][i] is not null)
                    oszlop.Add(tableInputForm.tableData[0][i]);
            }
            string metszet;
            string metszetMuvelet = string.Empty;
            int metszetSzam = 0;
            do
            {
                for (int i = 0; i < sor.Count; i++)
                {
                    if (i != 0)
                    {
                        if (stack.Count() != 0)
                        {
                            if (stack.Peek() == sor[i])
                            {
                                stack.Pop();
                                for (int j = 0; j < oszlop.Count; j++)
                                {
                                    if (input[index].ToString() == oszlop[j])
                                    {
                                        if (tableInputForm.tableData[i][j] is not null)
                                        {
                                            metszet = tableInputForm.tableData[i][j];
                                            helper(metszet, ref isDone, metszetMuvelet, metszetSzam, sb, input);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            } while (!isDone);

            outPutList.Add(sb.ToString());
        }
        static string ReplaceNumbers(string inputString, string replacementString)
        {
            Stack<string> stack2 = new Stack<string>(Regex.Split(inputString, @"([\+\-\*/\(\)])"));
            Stack<string> tempStack = new Stack<string>();

            while (stack2.Count > 0)
            {
                string current = stack2.Pop();

                // Check if the current item is a number
                if (int.TryParse(current, out int number))
                {
                    tempStack.Push(replacementString);
                }
                else
                {
                    tempStack.Push(current);
                }
            }

            // Revert the order and concatenate back to a string
            string modifiedString = string.Join("", tempStack);

            return modifiedString;
        }

        private void inputStripTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void stackInputTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void helper(string metszet, ref bool isDone, string metszetMuvelet, int metszetSzam, StringBuilder sb, string input)
        {
            if (metszet is null)
                isDone = true;
            string elemek = "";
            Match match = Regex.Match(metszet, @"\d+$"); //utolsó szám elem megtalálása stringben regexel
            elemek = match.Value;

            Regex regex = new Regex(@"[()]+");
            metszet = regex.Replace(metszet, "");

            string[] temp = metszet.Split(",");
            if (temp.Count() >= 2)
            {
                metszetMuvelet = temp[0]; //szabály művelet
                metszetSzam = int.Parse(temp[1]); //szabály száma
            }

            if (metszet == "accept")
            {
                isDone = true;
                sb.Append("elfogadva");
            }
            else if (metszet == "pop")
            {
                index++;
            }
            else if (metszetMuvelet == "e")
            {
                numberOfMetszetSzam += metszetSzam;
            }
            else
            {
                for (int i = metszetMuvelet.Length - 1; i >= 0; i--)
                {
                    if (Convert.ToString(metszetMuvelet[i]) == "'")
                    {
                        stack.Push(metszetMuvelet[i - 1].ToString() + metszetMuvelet[i].ToString());
                        i--;
                    }
                    else
                    {
                        stack.Push(metszetMuvelet[i].ToString());
                    }
                }
                if (metszetSzam != 0)
                    numberOfMetszetSzam += metszetSzam;
            }

            sb.Append('(');
            sb.Append(input);
            sb.Append(',');
            sb.Append(metszet);
            sb.Append(',');
            sb.Append(numberOfMetszetSzam.ToString());
            sb.Append(')');
            sb.Append('\n');
        }
    }
}
