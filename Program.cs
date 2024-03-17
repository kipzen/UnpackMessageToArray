Console.WriteLine("====================================\n====================================\n=====MANDATES IRD======\n====================================\n====================================");

//string ISOresponse = "ISO0001103309238000002008000000000000500E000-000162701310402100702001007100702022800KES101148929932035WATAKO KIRUI &CO ADVOCATE-CLIENT AC044012260^TEL.254723540142^TEL.254202211384/254202694229^TEL.254202211384/254202694229^kiruirodah@yahoo.com^info@watakokiruiadvocates.co.ke^info@watakokiruiadvocates.co.ke^^null^null^null^null^^null^null^null^null^^RODAH KIRUI^VINCENT MULONDO WATAKO^RUTH SELPHER ASWANI086^20140207130970072^201712204910302558.jpg^20171206681482031.jpg^201712069719028259.jpg";
// ISOresponse = "ISO0001103309238000002008000000000000500E000-000069766700109013134000131013134091300KES101147722188023NICHOLAS WANYUTU WAWERU044001089254725133771^254725133771^nicowayke@gmail.com^^SOLE^^ID 25215374^^NICHOLAS WANYUTU WAWERU023^201612204646519199.jpg";
string ISOresponse = "ISO0001103309238000002008000000000000500E000-000069766700109013134000131013134091300KES101147722188023NICHOLAS WANYUTU WAWERU044001089254725133771^254725133771^nicowayke@gmail.com^^SOLE^^ID 25215374^^NICHOLAS WANYUTU WAWERU023^201612204646519199.jpg";

string AccountDetailsHeader = ISOresponse.Substring(0,99);
Console.WriteLine("Header: "+AccountDetailsHeader);
string AccountDetails = ISOresponse.Substring(99);
Console.WriteLine("ImageDetails:"+AccountDetails);

// DAO Details
int AccountDetailscount = Convert.ToInt32(AccountDetails.Substring(0, 3));
Console.WriteLine("DAO Count:\n\n "+AccountDetailscount);
int DAO = 6;
string NamedetailsDAO = AccountDetails.Substring(0, AccountDetailscount + DAO + 3);
Console.WriteLine("DAO Details: \n\n "+NamedetailsDAO.Length+ "Value:"+ NamedetailsDAO);

// phonenumbers
Console.WriteLine("===================\n==Phone Numbers=====================\n");
int imagecountdetails = Convert.ToInt32(NamedetailsDAO.Length);
int imagedetails = Convert.ToInt32(AccountDetails.Substring(imagecountdetails, 3));
Console.WriteLine(imagedetails);
string imgphonedetails = AccountDetails.Substring(imagecountdetails+3, imagedetails);
Console.WriteLine("AccountDetails: "+imgphonedetails);
string[] arrayimgphonedetails = imgphonedetails.Split('^');

int Tel = 0;
int Telem = 0;

string Accphone = "";
string Emails = "";

foreach (string tele in arrayimgphonedetails.Distinct())
{  

    if (tele != null && tele.Contains("TEL"))
    {
        Tel = Tel + 1;
       // Console.WriteLine(string.Format("Phone: No: " + Tel + " " + tele));
        if (Accphone == "")
        {
            Accphone = tele;
        }
        else
        {
            Accphone = Accphone + "^" + tele;
        }
      //   Console.WriteLine(string.Format("Phone: No:   " + tele));

    }

    if (tele != null && tele.Contains("@"))
    {
        Telem = Telem + 1;
       // Console.WriteLine(string.Format("Email: " + Telem + " " + tele));

        if (Emails == "")
        {
            Emails = tele;
        }
        else
        {
            Emails = Emails + "^" + tele;
        }
    }

}
Console.WriteLine(string.Format("Phone: No:" + Accphone.Replace("TEL.","")));
Console.WriteLine(string.Format("Email Address:" + Emails));
string accountname = NamedetailsDAO.Substring(3, AccountDetailscount);
Console.WriteLine("AccountName: " + accountname);

//listAccountInfo.Add((!ISOBlank) ? accountPhone : ""); //Telephone
//listAccountInfo.Add((!ISOBlank) ? email : ""); //Email
//listAccountInfo.Add((!ISOBlank) ? mandate : ""); //Mandate
//listAccountInfo.Add((!ISOBlank) ? "" : ""); //Mandate Name
//listAccountInfo.Add((!ISOBlank) ? "" : ""); //Mandate Instruction
//listAccountInfo.Add((!ISOBlank) ? "" : ""); //ID Number
//listAccountInfo.Add((!ISOBlank) ? acountName : "");//Account Name
//

Console.WriteLine("===================\n==Images=====================\n");
// Actualimages
string imgimge = AccountDetails.Substring(imgphonedetails.Length + 3 + imagecountdetails);
Console.WriteLine("AccountImages:" + imgimge);
int imgcharcount = Convert.ToInt32(imgimge.Substring(0,3));
Console.WriteLine(imgcharcount);
string imgesstring = (imgimge.Substring(3, imgcharcount)).Substring(1);


Console.WriteLine("All Images: "+imgesstring);
string [] arrayimges = imgesstring.Split('^');
int a = 0;

foreach (string s in arrayimges)
{
    a = a + 1;
    Console.WriteLine(string.Format("Image: No: " + a + " " + s));
}

 AccountDetailsHeader = ISOresponse.Substring(0, 99);
 AccountDetails = ISOresponse.Substring(99);
Console.WriteLine("AccountDetails:" + AccountDetails);

//  AccountDetails: 035WATAKO KIRUI &CO ADVOCATE-CLIENT AC044012260^TEL.254723540142^TEL.254202211384/254202694229^TEL.254202211384/254202694229^kiruirodah@yahoo.com^info@watakokiruiadvocates.co.ke^info@watakokiruiadvocates.co.ke^^null^null^null^null^^null^null^null^null^^RODAH KIRUI^VINCENT MULONDO WATAKO^RUTH SELPHER ASWANI086^20140207130970072^201712204910302558.jpg^20171206681482031.jpg^201712069719028259.jpg

int startIndexAccountName = 3;

int startIndexAccountNameLength = Convert.ToInt32(AccountDetails.Substring(0, 3)); // 

string AccountName = AccountDetails.Substring(startIndexAccountName, startIndexAccountNameLength); // WATAKO
Console.WriteLine("AccountNameDetails:" + AccountName);

int DAOLength = 6;

int startIndexPhoneNumber = startIndexAccountName + startIndexAccountNameLength + DAOLength;

int startIndexPhoneNumberLength = Convert.ToInt32(AccountDetails.Substring(startIndexPhoneNumber, 3)); //260

int startIndexPhoneNumberdetails = startIndexPhoneNumber + 3;

string PhoneNumberdetails = AccountDetails.Substring(startIndexPhoneNumberdetails, startIndexPhoneNumberLength); // ^TEL.254723540142^TEL.254202211384/254202694229^TEL.25
Console.WriteLine("PhoneNumberDetails:" + PhoneNumberdetails);
// All images
int startIndexImages = startIndexPhoneNumberdetails + startIndexPhoneNumberLength; // 

int startIndexImageLength = Convert.ToInt32(AccountDetails.Substring(startIndexImages, 3)); // 086

int startIndeximagedetails = startIndexImages + 3;

string imagedetailsTest = AccountDetails.Substring(startIndeximagedetails, startIndexImageLength);


Console.WriteLine("ImageDetails:" + imagedetailsTest);


