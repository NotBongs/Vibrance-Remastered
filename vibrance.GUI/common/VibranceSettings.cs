using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vibrance.GUI.common
{
    public partial class VibranceSettings : Form
    {
        private IVibranceProxy _v;
        private ListViewItem _sender;
        private readonly Func<int, string> _resolveLabelLevel;
        private Point mouseOffset;
        private bool isMouseDown = false;

        public VibranceSettings(IVibranceProxy v, int minValue, int maxValue, int defaultValue, ListViewItem sender, ApplicationSetting setting, List<ResolutionModeWrapper> supportedResolutionList, Func<int, string> resolveLabelLevel)
        {
            InitializeComponent();
            panel1.MouseDown += PanelMouseDown;
            panel1.MouseMove += PanelMouseMove;
            panel1.MouseUp += PanelMouseUp;
            this.trackBarIngameLevel.Minimum = minValue;
            this.trackBarIngameLevel.Maximum = maxValue;
            this.trackBarIngameLevel.Value = defaultValue;
            this._sender = sender;
            _resolveLabelLevel = resolveLabelLevel;
            this._v = v;
            labelIngameLevel.Text = _resolveLabelLevel(trackBarIngameLevel.Value);
            this.labelTitle.Text += $@"""{sender.Text}""";
            this.pictureBox.Image = this._sender.ListView.LargeImageList.Images[this._sender.ImageIndex];
            this.cBoxResolution.DataSource = supportedResolutionList;
            // If the setting is new, we don't need to set the progress bar value
            if (setting != null)
            {
                // Sets the progress bar value to the Ingame Vibrance setting
                this.trackBarIngameLevel.Value = setting.IngameLevel;
                this.cBoxResolution.SelectedItem = setting.ResolutionSettings;
                this.checkBoxResolution.Checked = setting.IsResolutionChangeNeeded;
                // Necessary to reload the label which tells the percentage
                trackBarIngameLevel_Scroll(null, null); 
            }
        }

        private void trackBarIngameLevel_Scroll(object sender, EventArgs e)
        {
            _v.SetVibranceIngameLevel(trackBarIngameLevel.Value);
            labelIngameLevel.Text = _resolveLabelLevel(trackBarIngameLevel.Value);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public ApplicationSetting GetApplicationSetting()
        {
            return new ApplicationSetting(_sender.Text, _sender.Tag.ToString(), this.trackBarIngameLevel.Value, 
                (ResolutionModeWrapper)this.cBoxResolution.SelectedItem, this.checkBoxResolution.Checked);
        }

        private void checkBoxResolution_CheckedChanged(object sender, EventArgs e)
        {
            this.cBoxResolution.Enabled = this.checkBoxResolution.Checked;
        }

        private void SettingsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void PanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void PanelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
