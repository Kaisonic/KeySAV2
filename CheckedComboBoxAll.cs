/*
    Copyright 2015 Thomas DeBell (Kaisonic)

    This file is part of KeySAV2 - Kaisonic Edition.

    KeySAV2 - Kaisonic Edition is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    KeySAV2 - Kaisonic Edition is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckComboBox 
{
    class CheckedComboBoxAll : CheckedComboBox
    {
        private bool inItemCheckHandler = true;

        internal class DropdownA : Dropdown
        {
            public override string GetCheckedItemsStringValue() {
                if (this.ccbParent.GetItemCheckState(0) == CheckState.Checked)
                    return cclb.GetItemText(cclb.Items[0]);
                StringBuilder sb = new StringBuilder("");
                for (int i = 1; i < cclb.CheckedItems.Count; i++) {                    
                    sb.Append(cclb.GetItemText(cclb.CheckedItems[i])).Append(ccbParent.ValueSeparator);
                }
                if (sb.Length > 0) {
                    sb.Remove(sb.Length - ccbParent.ValueSeparator.Length, ccbParent.ValueSeparator.Length);
                }
                return sb.ToString();
            }

            public DropdownA(CheckedComboBox parent) : base(parent) {}
        }

        public CheckedComboBoxAll() : base()
        {
            this.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.updateAllBox);
            this.dropdown = new DropdownA(this);
            this.CheckOnClick = true;
        }

        private void updateAllBox(object sender, ItemCheckEventArgs e)
        {
            if (inItemCheckHandler)
            {
                inItemCheckHandler = false;
                if (e.Index == 0)
                {
                    for (byte i = 1; i < this.Items.Count; ++i)
                        this.dropdown.List.SetItemCheckState(i, e.NewValue);
                }
                else if (this.CheckedItems.Count == 2 && e.NewValue == CheckState.Unchecked)
                    this.dropdown.List.SetItemCheckState(0, CheckState.Unchecked);
                else if (this.CheckedItems.Count == this.Items.Count - 1 && e.NewValue == CheckState.Checked)
                    this.dropdown.List.SetItemCheckState(0, CheckState.Checked);
                else
                    this.dropdown.List.SetItemCheckState(0, CheckState.Indeterminate);
                inItemCheckHandler = true;
            }
        }
    }
}
