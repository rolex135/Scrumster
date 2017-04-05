using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrumster
{
    public partial class Scrumster : Form
    {
        private string storyBoxPlaceHolder = "Enter new story text here...";
        private string todoBoxPlaceHolder = "Enter new TODO here...";

        public Scrumster()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult aboutInfo = MessageBox.Show("Scrumster is made by: Martin. Version 0.1");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newStory_Click(object sender, EventArgs e)
        {
            if (checkTextForLengthAndPlaceholder(storyTextBox, storyBoxPlaceHolder))
            {
                storyList.Items.Add(storyTextBox.Text);
            }
        }


        private void storyTextBox_Enter(object sender, EventArgs e)
        {
            storyTextBox.Text = "";
        }

        private void storyTextBox_Leave(object sender, EventArgs e)
        {
            if (storyTextBox.Text.Length < 1)
            {
            storyTextBox.Text = storyBoxPlaceHolder;
            }
        }

        private void newTodo_Click(object sender, EventArgs e)
        {
            if(checkTextForLengthAndPlaceholder(todoTextBox, todoBoxPlaceHolder))
            {
                todoList.Items.Add(todoTextBox.Text);
            }
        }

        private Boolean checkTextForLengthAndPlaceholder(TextBox textBox, string placeHolderText)
        {
            if (textBox.Text.Length > 0 && (textBox.Text != placeHolderText))
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
