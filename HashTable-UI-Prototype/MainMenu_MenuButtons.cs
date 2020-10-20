using System;
using System.Windows.Forms;
using HashTable_UI_Prototype.SubForms;

namespace HashTable_UI_Prototype
{
    public partial class MainMenu
    {
        /// <summary>
        /// 
        /// </summary>
        private void ClearAllButtons()
        {
            btn_Home.BackColor = MainMenu.NOT_SELECTED_BUTTON_COLOR;
            btn_UploadData.BackColor = MainMenu.NOT_SELECTED_BUTTON_COLOR;
            btn_Searching.BackColor = MainMenu.NOT_SELECTED_BUTTON_COLOR;
            btn_Visualisation.BackColor = MainMenu.NOT_SELECTED_BUTTON_COLOR;
            btn_StoredData.BackColor = MainMenu.NOT_SELECTED_BUTTON_COLOR;
        }

        /// <summary>
        /// Действия при нажатии на кнопку "Home".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (this.activeForm == homeForm) return;

            if (activeForm != null)
                activeForm.Hide();

            ClearAllButtons();
            btn_Home.BackColor = Home_Form.HIGHLIGHT_COLOR;
            Header_Panel.BackColor = Home_Form.HIGHLIGHT_COLOR;

            ChangeHeaderName(btn_Home);

            activeForm = homeForm;
            this.DoFillActiveInPanelStaff();

            HighLightingOfHelpButton();
        }

        /// <summary>
        /// Действия при нажатии на кнопку "Upload data"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UploadData_Click(object sender, EventArgs e)
        {
            // Надеюсь, что activeForm не сможет получить null
            // Сначала проверяем, не открыта ли уже эта вкладка
            // Если уже открыта - ничего не делаем
            if (this.activeForm == uploadDataForm) return;

            // Если сейчас открыта другая вкладка, тогда проверяем, была ли открыта форма загрузки данных
            // Если не была - создаём её
            if (uploadDataForm == null) 
                uploadDataForm = new UploadData_Form(this);          

            // Если открыта другая вкладка и у нас есть созданная форма загрузки - проверяем нужно ли скрыть текущую
            if (activeForm != null)
                activeForm.Hide();

            ClearAllButtons();
            btn_UploadData.BackColor = UploadData_Form.HIGHLIGHT_COLOR;
            Header_Panel.BackColor = UploadData_Form.HIGHLIGHT_COLOR;

            ChangeHeaderName(btn_UploadData);

            activeForm = uploadDataForm;
            this.DoFillActiveInPanelStaff();

            HighLightingOfHelpButton();
        }

        /// <summary>
        /// Действия при нажатии на кнопку "Searching"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Searching_Click(object sender, EventArgs e)
        {
            // Если вкладка уже открыта - ничего не делаем
            if (this.activeForm == searchForm) return;

            // Если вкладка не была прежде ни разу открыта - создаём её
            if (searchForm == null)
                searchForm = new SearchForm(this);

            // Если открыта вдругая вкладка - скрываем её
            if (activeForm != null)
                activeForm.Hide();

            ClearAllButtons();
            btn_Searching.BackColor = SearchForm.HIGHLIGHT_COLOR;
            Header_Panel.BackColor = SearchForm.HIGHLIGHT_COLOR;

            ChangeHeaderName(btn_Searching);

            activeForm = searchForm;
            this.DoFillActiveInPanelStaff();

            HighLightingOfHelpButton();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Visualisation_Click(object sender, EventArgs e)
        {
            // Если вкладка уже открыта - ничего не делаем
            if (this.activeForm == visualForm) return;

            // Если вкладка не была прежде ни разу открыта - создаём её
            if (visualForm == null)
                visualForm = new VisualisationForm(this);

            // Если открыта вдругая вкладка - скрываем её
            if (activeForm != null)
                activeForm.Hide();

            ClearAllButtons();
            btn_Visualisation.BackColor = VisualisationForm.HIGHLIGHT_COLOR;
            Header_Panel.BackColor = VisualisationForm.HIGHLIGHT_COLOR;

            ChangeHeaderName(btn_Visualisation);

            activeForm = visualForm;
            this.DoFillActiveInPanelStaff();

            HighLightingOfHelpButton();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StoredData_Click(object sender, EventArgs e)
        {
            // Если вкладка уже открыта - ничего не делаем
            if (this.activeForm == storedDataForm) return;

            // Если вкладка не была прежде ни разу открыта - создаём её
            if (storedDataForm == null)
                storedDataForm = new StoredDataForm(this);

            // Если открыта вдругая вкладка - скрываем её
            if (activeForm != null)
                activeForm.Hide();

            ClearAllButtons();
            btn_StoredData.BackColor = StoredDataForm.HIGHLIGHT_COLOR;
            Header_Panel.BackColor = StoredDataForm.HIGHLIGHT_COLOR;

            ChangeHeaderName(btn_StoredData);

            activeForm = storedDataForm;
            this.DoFillActiveInPanelStaff();

            HighLightingOfHelpButton();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="btn"></param>
        private void ChangeHeaderName(Button btn)
        {
            btn_Header.Text = btn.Text.ToUpper();
        }
     }
}
