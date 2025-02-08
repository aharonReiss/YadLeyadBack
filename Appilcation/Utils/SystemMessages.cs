using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Utils
{
    public static class SystemMessages
    {
        //validation messages
        public const string WrongMail = "אימייל לא תקין";
        public const string WrongPassword = "סיסמא לא תקינה";
        public const string WrongThelephoneNumber = "מספר פלאפון לא תקין";
        public const string WrongFirstName = "שם לא תקין";
        public const string WrongLastName = "שם משפחה לא תקין";

        //user message
        public const string UserAlreadyExist = "יוזר קיים במערכת";
        public const string AuthenticationProcessFailed = "תהליך ההזדהות נכשל";
        public const string UserAdded = "יוזר התווסף בהצלחה";

        //task messages
        public const string TaskAddFailed = "הוספת משימה נכשלה";
        public const string TaskNotExist = "משימה לא נמצאה";
        public const string TaskAdded = "המשימה התווספה בהצלחה";
        public const string DeleteTaskMessage = "משימה נמחקה בהצלחה, מספר משימה: ";
        public const string UpdateTaskMessage = "המשימה התעדכנה בהצלחה";

        //system messages
        public const string ActionFailed = "פעולה נכשלה";
        public const string TokenNotExist = "טוקן לא קיים";
    }
}
