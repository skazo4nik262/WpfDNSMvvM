using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDNSMvvM.Model;

namespace ViewModelsMvvm.WpfDNSMvvM.ViewModel
{
    public class CpuWinVM : BaseVM
    {
        private CPU cpu;

        public CPU Cpu
        {
            get => cpu;
            set
            {
                cpu = value;
                Signal();
            }
        }

        public CommandVM AddCpu { get; }

        public ObservableCollection<CPU> CPUs { get; set; }

        public CpuWinVM()
        {
            AddCpu = new CommandVM(() =>
            {
                CPUs.Add(cpu);
                Cpu = new CPU();
            });
            CPUs = new();

            Cpu = new CPU();
        }
    }
}
