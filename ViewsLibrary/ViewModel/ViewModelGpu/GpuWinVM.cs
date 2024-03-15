using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDNSMvvM.Model;

namespace ViewModelsMvvm.WpfDNSMvvM.ViewModel
{
    public class GpuWinVM : BaseVM
    {
        private GPU gpu;

        public GPU Gpu
        {
            get => gpu;
            set
            {
                gpu = value;
                Signal();
            }
        }

        public CommandVM AddGpu { get; }

        public ObservableCollection<GPU> GPUs { get; set; }

        public GpuWinVM()
        {
            AddGpu = new CommandVM(() =>
            {
                GPUs.Add(gpu);
                Gpu = new GPU();
            });
            GPUs = new();

            Gpu = new GPU();
        }
    }
}