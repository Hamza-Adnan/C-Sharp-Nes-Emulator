using System.Windows.Forms;

namespace NESDOTNET.Controllers
{
    interface IController
    {
        void Strobe(bool on);

        int ReadState();

        void PressKey(KeyEventArgs e);

        void ReleaseKey(KeyEventArgs e);
    }
}
