using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataBinding101.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBinding101
{
    public partial class Form1 : Form
    {
        DataBindingContext context = new DataBindingContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Characters.Include(c => c.Equipment).Load();
            characterBindingSource.DataSource = context.Characters.Local.ToBindingList();
        }

        private void characterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            characterBindingSource.EndEdit();

            equipmentDataGridView.EndEdit();
            equipmentBindingSource.EndEdit();

            context.SaveChanges();
            Form1_Load(null, null);
        }

        private void CheckForCharacterId(object sender, EventArgs e)
        {
            Character current = (Character)characterBindingSource.Current;
            //MessageBox.Show(current.CharacterId.ToString());
            if (current.CharacterId==0)
            {
                characterBindingNavigatorSaveItem.PerformClick();
            }
        }
    }
}
