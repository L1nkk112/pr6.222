using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace pr6._22
{
    public partial class Form1 : Form
    {
        private CarFacade carFacade;
        interface IEngine
        {
            void Start();
            void Stop();
        }
        /// <summary>
        /// Интерфейс IFuelSystem отвечает за топливную систему
        /// </summary>
        interface IFuelSystem
        {
            void SupplyFuel();
            void CutOffFuel();
        }
        /// <summary>
        /// Интерфейс ILights отчвает за работу фар
        /// </summary>
        interface ILights
        {
            void TurnOn();
            void TurnOff();
        }
        /// <summary>
        /// Интерфейс ICarDiagnostic отчвает за диагностику бортовой панели
        /// </summary>
        interface ICarDiagnostic
        {
            void RunDiagnostic();
        }
        public class Engine : IEngine
        {
            public void Start() { MessageBox.Show("Попытка запустить двигатель!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            public void Stop() { MessageBox.Show("Двигатель заглушен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        class FuelSystem : IFuelSystem
        {
            public void SupplyFuel() { MessageBox.Show("Подача топлива!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            public void CutOffFuel() { MessageBox.Show("Прекращение подачи топлива!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        class Lights : ILights
        {
            public void TurnOn() { MessageBox.Show("Попытка включить фары!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            public void TurnOff() { }
        }
        class CarDiagnostic : ICarDiagnostic
        {
            public void RunDiagnostic() { }
        }
        class CarFacade
        {
            private IEngine engine;
            private IFuelSystem fuelSystem;
            private ILights lights;
            private ICarDiagnostic carDiagnostic;
            public CarFacade()
            {
                engine = new Engine();
                fuelSystem = new FuelSystem();
                lights = new Lights();
                carDiagnostic = new CarDiagnostic();
            }
            public delegate void CarAction();
            public CarAction StartEngine => engine.Start;
            public CarAction StopEngine => engine.Stop;
            public CarAction SupplyFuel => fuelSystem.SupplyFuel;
            public CarAction CutOffFuel => fuelSystem.CutOffFuel;
            public CarAction TurnOnLights => lights.TurnOn;
            public CarAction TurnOffLights => lights.TurnOff;
            public CarAction RunDiagnostics => carDiagnostic.RunDiagnostic;
        }
        public Form1()
        {
            InitializeComponent();
            carFacade = new CarFacade();
        }
        class RandomHelper
        {
            private static Random rnd = new Random();

            public static int GetRandomInt(int maxValue)
            {
                return rnd.Next(maxValue);
            }
        }
        private void btnStartEngine_Click(object sender, EventArgs e)
        {
            carFacade.StartEngine();
            int random = RandomHelper.GetRandomInt(5);
            if (random == 0)
            {
                MessageBox.Show("Машина не запускается!", "Стартер сломался", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {System.Diagnostics.Process.Start(@"D:\Users\1213-11\Documents\2-ИСП\Проектирование и дизайн информационных систем\Ghbptynfirf\запуск.gif");}
        }
        private void btnStopEngine_Click(object sender, EventArgs e)
        {
            carFacade.StopEngine();
        }
        private void btnSupplyFuel_Click(object sender, EventArgs e)
        {
            int random = RandomHelper.GetRandomInt(5);
            if (random == 0)
            {
                MessageBox.Show("Машина не заводится!", "Топливный насос сломался", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {System.Diagnostics.Process.Start(@"D:\Users\1213-11\Documents\2-ИСП\Проектирование и дизайн информационных систем\Ghbptynfirf\enginestart.gif");}
        }
            private void btnCutOffFuel_Click(object sender, EventArgs e)
            {
                carFacade.CutOffFuel();
            }
            private void btntTurnOnLights_Click(object sender, EventArgs e)
            {
                carFacade.TurnOnLights();
            int random = RandomHelper.GetRandomInt(5);
            if (random == 0)
            {
                    MessageBox.Show("Фары не включаются!", "Аккумулятор разрядлся", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {System.Diagnostics.Process.Start(@"D:\Users\1213-11\Documents\2-ИСП\Проектирование и дизайн информационных систем\Ghbptynfirf\c63.gif");}
            }
            private void btnRunDiagnostics_Click(object sender, EventArgs e)
            {
                carFacade.RunDiagnostics();
                System.Diagnostics.Process.Start(@"D:\Users\1213-11\Documents\2-ИСП\Проектирование и дизайн информационных систем\Ghbptynfirf\priborka.gif");
            }
            private void btnTurnOffLights_Click(object sender, EventArgs e)
            {
                carFacade.TurnOffLights();
                System.Diagnostics.Process.Start(@"D:\Users\1213-11\Documents\2-ИСП\Проектирование и дизайн информационных систем\Ghbptynfirf\off.jpg");
            }
            private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            private void выходToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Close();
            }
            private void btnBack_Click(object sender, EventArgs e)
            {
                выходToolStripMenuItem_Click(sender, e);
            }
        }
    }
