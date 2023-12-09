using System.Text;

namespace SpecGenerator
{
    public partial class SpecGenerator : Form
    {
        internal static MenuItem TotalMenu = new();

        public SpecGenerator()
        {
            InitializeComponent();
        }

        private void MenuAddButton_Click(object sender, EventArgs e)
        {
            var menuName = MenuNameTextBox.Text;

            if (string.IsNullOrEmpty(menuName))
            {
                return;
            }

            var item = new MenuItem()
            {
                ItemName = menuName,
                ChildItems = new List<MenuItem>()
            };

            TotalMenu.ChildItems.Add(item);
            MenuListBox.DataSource = null;
            MenuListBox.DataSource = TotalMenu.ChildItems;
            MenuListBox.DisplayMember = "ItemName";
            MenuNameTextBox.Text = string.Empty;
            MenuListBox.ClearSelected();
        }

        private void PageAddButton_Click(object sender, EventArgs e)
        {
            var pageName = PageNameTextBox.Text;

            if (MenuListBox.SelectedItem == null)
            {
                MessageBox.Show("請先點選Menu", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pageName))
            {
                return;
            }

            var item = new MenuItem()
            {
                ItemName = pageName,
                ChildItems = new List<MenuItem>()
            };

            var selectedItem = (MenuItem)MenuListBox.SelectedItem;

            selectedItem.ChildItems.Add(item);
            PageListBox.DataSource = null;
            PageListBox.DataSource = selectedItem.ChildItems;
            PageListBox.DisplayMember = "ItemName";
            PageNameTextBox.Text = string.Empty;
            PageListBox.ClearSelected();
        }

        private void ActionAddButton_Click(object sender, EventArgs e)
        {
            var actionName = ActionNameTextBox.Text;

            if (PageListBox.SelectedItem == null)
            {
                MessageBox.Show("請先點選Page", "Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(actionName))
            {
                return;
            }

            var item = new MenuItem()
            {
                ItemName = actionName
            };

            var selectedItem = (MenuItem)PageListBox.SelectedItem;

            selectedItem.ChildItems.Add(item);
            ActionListBox.DataSource = null;
            ActionListBox.DataSource = selectedItem.ChildItems;
            ActionListBox.DisplayMember = "ItemName";
            ActionNameTextBox.Text = string.Empty;
            ActionListBox.ClearSelected();
        }

        private void MenuRemoveButton_Click(object sender, EventArgs e)
        {
            var item = MenuListBox.SelectedItem as MenuItem ?? throw new Exception();

            TotalMenu.ChildItems.Remove(item);
            MenuListBox.DataSource = null;
            MenuListBox.DataSource = TotalMenu.ChildItems;
            MenuListBox.DisplayMember = "ItemName";
        }

        private void PageRemoveButton_Click(object sender, EventArgs e)
        {
            if (MenuListBox.SelectedItem == null)
            {
                return;
            }

            if (PageListBox.SelectedItem == null)
            {
                return;
            }

            var menuItem = (MenuItem)MenuListBox.SelectedItem;
            var pageItem = (MenuItem)PageListBox.SelectedItem;

            menuItem.ChildItems.Remove(pageItem);
            PageListBox.DataSource = null;
            PageListBox.DataSource = menuItem.ChildItems;
            PageListBox.DisplayMember = "ItemName";
            PageListBox.ClearSelected();
        }

        private void ActionRemoveButton_Click(object sender, EventArgs e)
        {
            if (PageListBox.SelectedItem == null)
            {
                return;
            }

            if (ActionListBox.SelectedItem == null)
            {
                return;
            }

            var pageItem = (MenuItem)PageListBox.SelectedItem;
            var actionItem = (MenuItem)ActionListBox.SelectedItem;

            pageItem.ChildItems.Remove(actionItem);
            ActionListBox.DataSource = null;
            ActionListBox.DataSource = pageItem.ChildItems;
            ActionListBox.DisplayMember = "ItemName";
            ActionListBox.ClearSelected();
        }

        private void TxtButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            foreach (var menu in TotalMenu.ChildItems)
            {
                // ┖ ┕ └ ─ ━
                sb.AppendLine($"╠═ {menu.ItemName}");

                foreach (var page in menu.ChildItems)
                {
                    sb.AppendLine($"║    ╠═ {page.ItemName}");

                    foreach (var action in page.ChildItems)
                    {
                        sb.AppendLine($"║          ╠═ {action.ItemName}");
                    }
                }
            }

            MessageBox.Show(sb.ToString());
        }

        private void MenuListBox_Click(object sender, EventArgs e)
        {
            if (MenuListBox.SelectedItem == null)
            {
                return;
            }

            PageListBox.DataSource = null;
            PageListBox.Items.Clear();

            var selectedItem = (MenuItem)MenuListBox.SelectedItem;

            PageListBox.DataSource = selectedItem.ChildItems;
            PageListBox.DisplayMember = "ItemName";
            PageListBox.ClearSelected();

            ActionListBox.DataSource = null;
            ActionListBox.Items.Clear();
        }

        private void PageListBox_Click(object sender, EventArgs e)
        {
            if (PageListBox.SelectedItem == null)
            {
                return;
            }

            ActionListBox.DataSource = null;
            ActionListBox.Items.Clear();

            var selectedItem = (MenuItem)PageListBox.SelectedItem;

            ActionListBox.DataSource = selectedItem.ChildItems;
            ActionListBox.DisplayMember = "ItemName";
            ActionListBox.ClearSelected();
        }
    }
}
