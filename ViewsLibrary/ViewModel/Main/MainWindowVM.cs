using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.View;
using WpfDNSMvvM.Model;

namespace ViewModelsMvvm.WpfDNSMvvM.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private CPU cpu;
        CpuWin cpuWin = new CpuWin();
        GpuWin gpuWin = new GpuWin();

        private GPU gpu;

        public CPU Cpu
        {
            get => cpu;
            set
            {
                cpu = value;
                Signal();
            }
        }

        public GPU Gpu
        {
            get => gpu;
            set
            {
                gpu = value;
                Signal();
            }
        }
        public CommandVM AddCpu { get; }
        public CommandVM AddGpu { get; }

        public ObservableCollection<CPU> CPUs { get; set; }
        public ObservableCollection<GPU> GPUs { get; set; }

        public MainWindowVM()
        {
            AddCpu = new CommandVM(() =>
            {
                cpuWin.Show();
                CPUs.Add(cpu);
                Cpu = new CPU();
            });
            CPUs = new();
            Cpu = new CPU();


            AddGpu = new CommandVM(() =>
            {
                gpuWin.Show();
                GPUs.Add(gpu);
                Gpu = new GPU();
            });
            GPUs = new();
            Gpu = new GPU();
        }
    }
}
