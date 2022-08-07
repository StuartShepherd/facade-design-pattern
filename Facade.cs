using System.Text;

namespace FacadeDesignPattern
{
    public class Facade
    {
        protected SubSystemAlpha _subSystemAlpha;

        protected SubSystemBeta _subSystemBeta;

        public Facade(
            SubSystemAlpha subSystemAlpha,
            SubSystemBeta subSystemBeta)
        {
            _subSystemAlpha = subSystemAlpha;
            _subSystemBeta = subSystemBeta;
        }

        public string Operation()
        {
            var result = new StringBuilder();
            result.AppendLine("Facade initializes subsystems:");
            result.AppendLine(_subSystemAlpha.Initialise());
            result.AppendLine(_subSystemBeta.Initialise());

            result.AppendLine("Facade performs the subsystems actions:");
            result.AppendLine(_subSystemAlpha.Process());
            result.AppendLine(_subSystemBeta.Process());
            return result.ToString();
        }

    }
}
