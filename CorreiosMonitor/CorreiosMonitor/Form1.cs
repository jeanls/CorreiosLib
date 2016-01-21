using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RastreamentoCorreios;
using System.Windows.Forms;
using MetroFramework;

namespace CorreiosMonitor
{
    public partial class Form1 : MetroForm
    {
        SpeechSynthesizer speech;
        Rastreamento rastreamento;
        List<Data> datas;
        int currentCount = 0;
        string currentCod = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rastreamento = new Rastreamento();
            speech = new SpeechSynthesizer();
            speech.SetOutputToDefaultAudioDevice();
            datas = new List<RastreamentoCorreios.Data>();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            gridDatas.Rows.Clear();
            spinner.Visible = true;
            datas = rastreamento.getCode(txtCod.Text);
            if(datas.Count > 0)
            {
                foreach(Data data in datas)
                {
                    gridDatas.Rows.Add(data.data, data.local, data.situacao, data.info);
                }
                spinner.Visible = false;
                currentCount = datas.Count;
                currentCod = txtCod.Text;
            }
            else
            {
                spinner.Visible = false;
                MetroMessageBox.Show(this, "Não foi possível localizar o objeto!", "Correios Monitor");
            }
        }

        private void monitorarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (monitorarCheckBox.Checked)
            {
                if(datas.Count > 0)
                {
                    monitorador.Start();
                }
                else
                {
                    monitorarCheckBox.Checked = false;
                    MetroMessageBox.Show(this, "Nenhum dado no sistema", "Correios Monitor");
                }
            }
            else
            {
                monitorador.Stop();
            }
        }

        private void monitorador_Tick(object sender, EventArgs e)
        {
            int atualCount = rastreamento.getCode(currentCod).Count;
            if (atualCount != currentCount)
            {
                speech.SpeakAsync("Novas Informações adicionadas");
                currentCount = atualCount; 
            } 
        }
    }
}
