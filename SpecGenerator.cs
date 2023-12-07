namespace SpecGenerator
{
    public partial class SpecGenerator : Form
    {
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

            MenuListBox.Items.Add(menuName);
            MenuNameTextBox.Text = string.Empty;
        }

        private void PageAddButton_Click(object sender, EventArgs e)
        {
            var pageName = PageNameTextBox.Text;

            if (string.IsNullOrEmpty(pageName))
            {
                return;
            }

            PageListBox.Items.Add(pageName);
            PageNameTextBox.Text = string.Empty;
        }

        private void ActionAddButton_Click(object sender, EventArgs e)
        {
            var actionName = ActionNameTextBox.Text;

            if (string.IsNullOrEmpty(actionName))
            {
                return;
            }

            ActionListBox.Items.Add(actionName);
            ActionNameTextBox.Text = string.Empty;
        }

        private void MenuRemoveButton_Click(object sender, EventArgs e)
        {
            MenuListBox.Items.Remove(MenuListBox.SelectedItem);
        }

        private void PageRemoveButton_Click(object sender, EventArgs e)
        {
            PageListBox.Items.Remove(PageListBox.SelectedItem);
        }

        private void ActionRemoveButton_Click(object sender, EventArgs e)
        {
            ActionListBox.Items.Remove(ActionListBox.SelectedItem);
        }

        private void TxtButton_Click(object sender, EventArgs e)
        {

        }
    }
}
