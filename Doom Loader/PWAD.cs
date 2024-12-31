﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom_Loader
{
    public partial class PWAD : Form
    {
        public PWAD()
        {
            InitializeComponent();
        }

        private void ManagerSetup(object sender, EventArgs e)
        {
            // Load PWADs into list
            if (ApplicationVariables.PWAD.Length != 0)
                foreach (string PWAD in ApplicationVariables.PWAD)
                    pwadList.Items.Add(Path.GetFileName(PWAD));

            // Setup tool tips
            toolTips.SetToolTip(button1, "Add File(s)");
            toolTips.SetToolTip(button2, "Remove File(s)");
            toolTips.SetToolTip(button3, "Reorder Selected Item Up");
            toolTips.SetToolTip(button4, "Reorder Selected Item Down");
        } // Ran at Startup, sets up tooltips and PWAD list

        /// <summary>
        /// Used to reload the PWAD Manager's PWAD List with the mods's filenames only
        /// </summary>
        /// <param name="listBox"></param>
        private static void Reload(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (string PWAD in ApplicationVariables.PWAD)
            {
                listBox.Items.Add(Path.GetFileName(PWAD));
            }
        }

        #region PWAD Addition & Removal
        private void AddPWAD(object sender, EventArgs e)
        {
            if (addPWADDialog.ShowDialog() != DialogResult.Cancel)
            {
                foreach (string PWAD in addPWADDialog.FileNames)
                {
                    List<string> PWADs = new(ApplicationVariables.PWAD.ToList()) { PWAD }; // Turn the original array into a usable list and add in the PWAD.
                    ApplicationVariables.PWAD = PWADs.ToArray(); // Merge the list into the array.
                }
                Reload(pwadList);
            }
        }

        private void RemovePWAD(object sender, EventArgs e)
        {
            try // Here to prevent crashing when no index was selected
            {
                List<string> PWADs = new(ApplicationVariables.PWAD.ToList()); // Turn the original array into a usable list.
                for (int i = pwadList.Items.Count - 1; i >= 0; i--)
                {
                    if (pwadList.GetSelected(i)) // If the PWAD in the PWAD Listbox is apart of the selected items, remove it.
                    {
                        PWADs.RemoveAt(i);
                    }
                }
                ApplicationVariables.PWAD = PWADs.ToArray(); // Turn the edited list back into an array
                Reload(pwadList);
            }
            catch { }
        }
        #endregion

        #region Reorder Buttons
        private void ReorderItemUp(object sender, EventArgs e)
        {
            if (pwadList.SelectedIndices.Count == 1)
            {
                string data = ApplicationVariables.PWAD[pwadList.SelectedIndex];
                int index = pwadList.SelectedIndex;
                if (index != 0) // Check if the item is not already at the top
                {
                    List<string> PWADs = new List<string>(ApplicationVariables.PWAD.ToList());
                    // Move the item
                    PWADs.RemoveAt(index);
                    PWADs.Insert(index - 1, data);
                    ApplicationVariables.PWAD = PWADs.ToArray();
                    Reload(pwadList);
                    pwadList.SelectedIndex = index - 1; // Set the cursor to the new position
                }
            }
        }

        private void ReorderItemDown(object sender, EventArgs e)
        {
            if (pwadList.SelectedIndices.Count == 1)
            {
                string data = ApplicationVariables.PWAD[pwadList.SelectedIndex];
                int index = pwadList.SelectedIndex;
                if (index != pwadList.Items.Count - 1) // Check if the item is not already at the bottom
                {
                    List<string> PWADs = new List<string>(ApplicationVariables.PWAD.ToList());
                    // Move the item
                    PWADs.RemoveAt(index);
                    PWADs.Insert(index + 1, data);
                    ApplicationVariables.PWAD = PWADs.ToArray();
                    Reload(pwadList);
                    pwadList.SelectedIndex = index + 1; // Set the cursor to the new position
                }
            }
        }
        #endregion

        #region File Drag And Drop
        private void PWADDragDrop(object sender, DragEventArgs e)
        {
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> PWADs = new(ApplicationVariables.PWAD.ToList());
            foreach (string item in items)
            {
                if (Directory.Exists(item)) continue; // Ignore item if it's a folder
                else
                {
                    PWADs.Add(item);
                }
            }
            ApplicationVariables.PWAD = PWADs.ToArray();
            Reload(pwadList);
        }

        private void PWADDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        #endregion
    }
}