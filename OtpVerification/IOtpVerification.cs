using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MhozaifaA.OtpVerification
{
    public interface IOtpVerification
    {
        OtpVia Generate(string id,string date);
        OtpVia Generate(string id, string date, out DateTime expire);
        OtpVia Generate(string id, string date, OtpVerificationOptions option);
        OtpVia Generate(string id, string date, OtpVerificationOptions option, out DateTime expire);
        bool Scan(string id, string date, string plain);
        bool Scan(string id, string date, string plain, OtpVerificationOptions option);
        bool Scan(string id, string date, string plain, int expire);
        bool Scan(string url);
    }
}
