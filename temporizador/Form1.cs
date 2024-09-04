namespace temporizador
{
    using System;
    using System.Windows.Forms;
    using System.Timers;

    public partial class Form1 : Form
    {
        private int horas;
        private int minutos;
        private int segundos;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "00:00:00"; // Inicializa o display do tempo
        }

        int h = 00, m = 00, s = 00;

        private void tempo1(object sender, EventArgs e)
        {
            // Corrige a condição de verificação para evitar comportamento inesperado
            if (horas != 0 || minutos != 0 || segundos != 0)
            {
                if (segundos > 0)
                {
                    segundos--;
                }
                else
                {
                    if (minutos > 0)
                    {
                        minutos--;
                        segundos = 59;
                    }
                    else if (horas > 0)
                    {
                        horas--;
                        minutos = 59;
                        segundos = 59;
                    }
                    else
                    {
                        timer.Stop();
                        // Você pode adicionar um som ou notificação aqui para indicar que o tempo acabou
                    }
                }

                // Atualiza o label com o tempo restante
                label1.Invoke((MethodInvoker)delegate
                {
                    AtualizarLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}");
                });
            }
            else
            {
                segundos++;
                if (segundos == 60)
                {
                    minutos++;
                    segundos = 00;
                }
                else if (minutos == 60)
                {
                    horas++;
                    minutos = 00;
                }
                // Atualiza o label com o tempo decorrido
                // AtualizarLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}");
            }
            AtualizarLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Método de carregamento do formulário
        }

        private void AtualizarLabel(string texto)
        {
            if (label1.InvokeRequired)
            {
                label1.Invoke((MethodInvoker)delegate {
                    label1.Text = texto;
                });
            }
            else
            {
                label1.Text = texto;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            horas = (int)horasinp.Value;
            minutos = (int)minutosinp.Value;
            segundos = (int)segundoinp.Value;

            timer = new System.Timers.Timer();
            timer.Interval = 2000; // Define o intervalo para 1 segundo
            timer.Elapsed += tempo1; // Conecta o evento Elapsed ao método tempo1
            timer.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer.Stop(); // Para o timer
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer.Dispose(); // Libera os recursos do timer
            h = 00;
            m = 00;
            s = 00;
            AtualizarLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}"); // Reseta o label para 00:00:00
        }
    }
}
