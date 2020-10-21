using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RezaB.API.TCKValidation.TCKValidationServiceReference;
using RezaB.API.TCKValidation.ForeignerTCKValidationServiceReference;

namespace RezaB.API.TCKValidation
{
    public class TCKValidationClient
    {
        private KPSPublicV2SoapClient InternalClient { get; set; }
        private KPSPublicYabanciDogrulaSoapClient ForeignerInternalClient { get; set; }
        public TCKValidationClient()
        {
            InternalClient = new KPSPublicV2SoapClient();
            ForeignerInternalClient = new KPSPublicYabanciDogrulaSoapClient();
        }

        public bool ValidateNewTCK(string TCKNo, string firstName, string lastName, DateTime birthDate, string registrationNo)
        {
            long parsedTCKNo;
            if (!long.TryParse(TCKNo.Trim(), out parsedTCKNo))
                return false;
            return InternalClient.KisiVeCuzdanDogrula(parsedTCKNo, firstName, lastName, false, birthDate.Day, false, birthDate.Month, false, birthDate.Year, null, null, registrationNo);
        }

        public bool ValidateOldTCK(string TCKNo, string firstName, string lastName, DateTime birthDate, string certificateNo, string certificateSerial)
        {
            long parsedTCKNo;
            if (!long.TryParse(TCKNo.Trim(), out parsedTCKNo))
                return false;
            int parsedCertificateNo;
            if (!int.TryParse(certificateNo.Trim(), out parsedCertificateNo))
                return false;
            return InternalClient.KisiVeCuzdanDogrula(parsedTCKNo, firstName, lastName, false, birthDate.Day, false, birthDate.Month, false, birthDate.Year, certificateSerial, parsedCertificateNo, null);
        }

        public bool ValidateOthers(string TCKNo, string firstName, string lastName, DateTime birthDate)
        {
            long parsedTCKNo;
            if (!long.TryParse(TCKNo.Trim(), out parsedTCKNo))
                return false;
            return ForeignerInternalClient.YabanciKimlikNoDogrula(parsedTCKNo, firstName, lastName, birthDate.Day, birthDate.Month, birthDate.Year);
        }

        public bool ValidateForeignerTCK(string TCKNo, string firstName, string lastName, DateTime birthDate)
        {
            long parsedTCKNo;
            if (!long.TryParse(TCKNo.Trim(), out parsedTCKNo))
                return false;
            return ForeignerInternalClient.YabanciKimlikNoDogrula(parsedTCKNo, firstName, lastName, birthDate.Day, birthDate.Month, birthDate.Year);
        }
    }
}
