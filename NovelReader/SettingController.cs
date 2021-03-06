﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelReader
{
    public partial class SettingController : UserControl
    {
        public SettingController()
        {
            InitializeComponent();
            SetControl();
        }

        /*============PrivateFunction=======*/

        private void SetControl()
        {
            audioExportLocationLabel.Text = Configuration.Instance.AudioExportLocation;
            textExportLocationLabel.Text = Configuration.Instance.TextExportLocation;

            dgvLanguageSelector.AutoGenerateColumns = false;
            Tuple<List<string>, List<string>> languageVoiceData = Util.GetLanguageVoice();
            List<string> languageList = languageVoiceData.Item1;
            List<string> voiceList = languageVoiceData.Item2;
            voiceList.Insert(0, "No Voice Selected");
            Dictionary<string, string> languageVoiceDictionary = Configuration.Instance.LanguageVoiceDictionary;
            if (languageVoiceDictionary == null)
                languageVoiceDictionary = new Dictionary<string, string>();

            DataGridViewCell languageCell = new DataGridViewTextBoxCell();
            DataGridViewComboBoxCell voiceCell = new DataGridViewComboBoxCell();

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn()
            {
                CellTemplate = languageCell,
                Name = "Language",
                HeaderText = "Language",
                Width = 250,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            DataGridViewComboBoxColumn voiceColumn = new DataGridViewComboBoxColumn()
            {
                CellTemplate = voiceCell,
                Name = "Voice",
                HeaderText = "Voice",
                DataSource = voiceList,
                ValueType = typeof(string),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = false,
                FlatStyle = FlatStyle.Popup
                //Width = 100
            };

            dgvLanguageSelector.Columns.Add(languageColumn);
            dgvLanguageSelector.Columns.Add(voiceColumn);

            foreach (KeyValuePair<string, string> kvp in languageVoiceDictionary)
            {
                dgvLanguageSelector.Rows.Add(kvp.Key, kvp.Value);
            }
            foreach (string language in languageList)
            {
                if (!languageVoiceDictionary.ContainsKey(language))
                {
                    dgvLanguageSelector.Rows.Add(language, "No Voice Selected");
                    languageVoiceDictionary.Add(language, "No Voice Selected");
                }
            }
            
            Configuration.Instance.LanguageVoiceDictionary = languageVoiceDictionary;

        }

        private void dgvLanguageSelector_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLanguageSelector.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                string language = dgvLanguageSelector.Rows[e.RowIndex].Cells["Language"].Value.ToString();
                string newVoice = dgvLanguageSelector.Rows[e.RowIndex].Cells["Voice"].Value.ToString();
                Configuration.Instance.LanguageVoiceDictionary[language] = newVoice;


            }
        }

        private void dgvLanguageSelector_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvLanguageSelector.IsCurrentCellDirty)
            {
                dgvLanguageSelector.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dgvLanguageSelector.EndEdit();
            }
                
        }

        private void dgvLanguageSelector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool validRow = (e.RowIndex != -1); //Make sure the clicked row isn't the header.
            bool validCol = (e.ColumnIndex != -1);
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (validRow && validCol && datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        private void upUpdateFreq_ValueChanged(object sender, EventArgs e)
        {
            BackgroundService.Instance.UpdateTimerInterval((int)upUpdateFreq.Value);
        }

        private void SettingController_Load(object sender, EventArgs e)
        {
            int updateInterval = Configuration.Instance.UpdateInterval;
            upUpdateFreq.Value = updateInterval / (1000 * 60);
        }

        private void audioExportBrowseButton_Click(object sender, EventArgs e)
        {
            if(exportFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                Configuration.Instance.AudioExportLocation = exportFolderBrowser.SelectedPath;
                audioExportLocationLabel.Text = Configuration.Instance.AudioExportLocation;
            }
        }

        private void textExportBrowseButton_Click(object sender, EventArgs e)
        {
            if (exportFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                Configuration.Instance.TextExportLocation = exportFolderBrowser.SelectedPath;
                textExportLocationLabel.Text = Configuration.Instance.TextExportLocation;
            }
        }
    }
}
