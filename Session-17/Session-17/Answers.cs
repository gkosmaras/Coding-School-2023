using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Session_17
{
    public class Answers
    {
        public List<string> Headers()
        {
            List<string> answerList = new List<string>
            {
                "Θα πρέπει να ελέγξουμε το documentation του API, οπού κανονικά θα πρέπει να υπάρχουν τα απαραίτητα στοιχεία για δημιουργία request, όπως το url, το body και τα headers.",
                "Content-type: image / jpeg",
                "Ορίζοντας στο cache-control το max-age του request να είναι 86400 (Τα δευτερόλεπτα σε μία μέρα)",
                "Ναι, καθώς τα GET είναι τρόπος παραλαβής δεδομένων από server.",
                "Κάνοντας χρήση API της μορφής Webhook, μπορούμε να έχουμε μόνο POST requests.",
                "400 Bad Request, καθώς στο documentation αναφέρει [...]client error (e.g., malformed request syntax, invalid request message framing[...]",
                "Αν η δεν υπάρχει επικοινωνία λόγω πτώσης του server ή maintenance τότε 503 Service Unavailable. Ειδάλλως 502 Bad Gateway.",
                "Ναι, αλλά καθώς πρόκεται για προσωπικά δεδομένα, καλύτερα να τα στέλνουμε κάνοντας χρήση της POST.",
                "To POST δημιουργεί ένα καινούριο αντικείμενο στο url του server κάθε φορά που καλείται, και το μόνο που απαιτέιται να γνωρίζουμε είναι το ίδιο το host url. Στέλνοντας δύο φορές την ίδια POST request δημιουργεί δύο αντικείμενα. Το PUT απαιτεί από τον χρήστη να ορίσει το url (host + endpoint). Αν το αντικείμενο υπάρχει ήδη, αντικαθίσταται.",
                "Χρησιμοποιούμε την μέθοδο POST, επιλέγουμε την καρτέλα Body -> binary, και select file για να επισυνάψουμε το αρχείο."
            };
            return answerList;
        }
    }
}
