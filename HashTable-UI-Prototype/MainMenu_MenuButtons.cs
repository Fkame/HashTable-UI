using System;

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

            activeForm = homeForm;
            this.DoFillActiveInPanelStaff();
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

            activeForm = uploadDataForm;
            this.DoFillActiveInPanelStaff();
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

            activeForm = searchForm;
            this.DoFillActiveInPanelStaff();
        }
    }
}
