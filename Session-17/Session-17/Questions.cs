using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_17
{
    public class Questions
    {
        public List<string> Headers()
        {
            List<string> questionList = new List<string>
            {
                "Πως μπορούμε να κάνουμε ένα Request σε ένα εξωτερικό API χωρίς να γνωρίζει ολόκληρο το url μας?",
                "Αν κάνω ενα GET request και ζητήσω ενα jpeg image, το response τι content-type πρεπει να εχει?",
                "Πως μπορώ να κάνω ένα GET request και το περιεχόμενο του να κρατηθεί στην cache για 1 μέρα?",
                "Μπορώ να έχω μια εφαρμογή που κάνει μόνο GET requests?",
                "Μπορώ να έχω μια εφαρμογή που κάνει μόνο POST requests?",
                "Τι status code περιμένω από ένα API αν δεν έχω στείλει ένα υποχρεωτικό πεδίο?",
                "Τι status code περιμένω από ένα API αν δεν υπάρχει επικοινωνία με τη βάση?",
                "Μπορώ να κάνω Login με GET request?",
                "Ποια είναι η διαφορά ανάμεσα στο PUT και στο POST?",
                "Ποια μέθοδο θα πρέπει να χρησιμοποιήσω για να «ανεβάσω» ένα αρχείο?"
            };
            return questionList;
        }
    }
}
