/* 
---------------------------------------------------------------------------------------------           
FUNCTION NAME: 	Trim
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Remove blank spaces
---------------------------------------------------------------------------------------------
*/

function Trim(pString)
{
  var i, resultado = "";
  pString = String(pString);
  if (pString.length > 0)
  {
    i = 0;
    while (pString.charAt(i) == " ") i++;
    resultado = pString.substring(i);

    i = resultado.length - 1;
    if (i > -1)
    {
      while (resultado.charAt(i) == " ") i--;
      resultado = resultado.substring(0, i + 1);
    }
  }
  return (resultado);
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  ValidaEmpties
       AUTHOR:	Cynthia Muñoz
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	
---------------------------------------------------------------------------------------------
*/
function ValidaEmpties(cadena, ObjectName, objecto)
{

  if (Trim(cadena)=="")
  {
    alert("El dato "+ ObjectName + "es obligatorio!!");
	objecto.focus();
  }  
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  Valida
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Validates that mandatory fields have been entered. If you want to call this
				function write Valida(document), besides in any field you must write:
				'required valueDifferent="" caption=""'. Example:
				<input type="text" required valueDifferent="" caption="First Name"/> 
				
				To call the function:
				if (Valida(document)){			  
				}
				
---------------------------------------------------------------------------------------------
*/

function Valida(objDocument)
{
  var 
    objComp, 
	sStrMessage = "";
  for(i=0; i < objDocument.all.length; i++)    
  {
    objComp = objDocument.all[i];
    if(objComp.required != null)
	{
	  if(Trim(objComp.value) == objComp.valueDifferent)
	  {
	    sStrMessage += "\n     - " + objComp.caption ;
		}
    }
  }
  if(sStrMessage != "")
  {
    alert("Fields missing:" + sStrMessage);
	return false;
   }
  else
    return true;	
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  DisableComponents
       AUTHOR:	Cynthia Muñoz
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Enable or Disable all the components according to the parameter it receives 
				(TRUE o FALSE)
---------------------------------------------------------------------------------------------
*/

function DisableComponents(B_value)
{  
   for (var o=0; o<document.all.length; o++ ) 
    { 
       document.all[o].readOnly = B_value;        
      } 
   DisableOtherComponents(B_value);	  
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  Bisiesto
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Verify if it is leaptyear (Bisiesto) or not                
---------------------------------------------------------------------------------------------
*/

function Bisiesto(year)
{
  return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  VerifyDate
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Verify if the date has the right format               
---------------------------------------------------------------------------------------------
*/

function VerifyDate(sStrFecha)
{
  if (sStrFecha == "") return (true);
  var fecha = sStrFecha.split("/");
  if (fecha.length != 3) return (false);
  if (isNaN(fecha[0]) || isNaN(fecha[1]) || isNaN(fecha[2])) return (false);
  if (fecha[0].length > 2 || fecha[0].length < 1 ||
      fecha[1].length > 2 || fecha[1].length < 1 ||
      fecha[2].length != 4)
    return (false);

  var d = parseInt(fecha[0], 10),
      m = parseInt(fecha[1], 10),
      y = parseInt(fecha[2], 10);

  if (y < 1900 || m > 12 || m < 1 || d < 1) return (false);
  switch (m)
  {
    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
	  if (d > 31) return (false)
	  break;
	case 2:
	  if (Bisiesto(y))
	  { if (d > 29) return (false) }
	  else if (d > 28)
	    return (false)
	  break;
	case 4: case 6: case 9: case 11:
	  if (d > 30) return (false)
	  break;
  }
  return (true);
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckDate
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Call the VerifyDate function and send a message if the date format is wrong 
  				It receives the date entered as parameter.
---------------------------------------------------------------------------------------------
*/
function CheckDate(sStrFecha)
{
  if (!VerifyDate(sStrFecha))
  {
    alert("Invalid date format. (Day/Month/Year)");
	if (event.srcElement != null)
	  event.srcElement.focus();
	return (false);
  }
  else
    return (true);
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  VerifyTime
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Verify if the time has the right format
---------------------------------------------------------------------------------------------
*/
function VerifyTime(strTime)
{
  if (strTime == "") return (true);
  var time = strTime.split(":");
  if (time.length < 2 || time.length > 3) return (false);
  if (time.length < 3) time[2] = "00";
  if (isNaN(time[0]) || isNaN(time[1]) || isNaN(time[2])) return (false);
  if (time[0].length > 2 || time[0].length < 1 ||
      time[1].length > 2 || time[1].length < 1 ||
      time[2].length > 2 || time[2].length < 1)
    return (false);

  var h = parseInt(time[0], 10),
      m = parseInt(time[1], 10),
      s = parseInt(time[2], 10);

  if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59) return (false);
  return (true);
}


/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckTime
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Call the VerifyTime function and send a message if the time format is wrong 
  				It receives the time entered as parameter.
---------------------------------------------------------------------------------------------
*/
function CheckTime(strTime)
{
  if (!VerifyTime(strTime))
  {
    alert("The time you have enter was wrong! The format is Hours:Minutes[:Seconds].");
    if (event.srcElement != null)
      event.srcElement.focus();
    return (false);
  }
  else
    return (true);
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  VerifyDateTime
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Verify if the datetime has the right format
---------------------------------------------------------------------------------------------
*/
function VerifyDateTime(strDateTime)
{
  if (strDateTime == "") return (true);
  if (strDateTime.indexOf(" ") == -1) return (false);
  var fecha = strDateTime.substring(0, strDateTime.indexOf(" ")),
      time = strDateTime.substring(strDateTime.indexOf(" ") + 1);
  
  return (VerifyDate(fecha) && VerifyTime(time));
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckDateTime
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Call the VerifyDateTime function and send a message if the time format is wrong 
  				It receives the DateTime entered as parameter.
---------------------------------------------------------------------------------------------
*/
function CheckDateTime(strDateTime)
{
  if (!VerifyDateTime(strDateTime))
  {
    alert("Invalid date and time format. (Day/Month/Year Hours:Minutes)");
    if (event.srcElement != null)
      event.srcElement.focus();
    return (false);
  }
  else 
    return (true);  
}


/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckDateTimeFormat
       AUTHOR:	Enrique Bassallo
  CREATE DATE: 	05/28/2002 
  DESCRIPTION: 	Verify DateTime with the Format parameter and send a message 
                if the date format is wrong. 
				It receives the datetime entered and format as parameters.
				Formats:
				  d  - Verify the day as a number without a leading zero (1-31). 
				  dd - Verify the day as a number with a leading zero (01-31). 
				  m  - Verify the month as a number without a leading zero (1-12).
				  mm - Verify the month as a number with a leading zero (01-12).
				  yy - Verify the year as a two-digit number (00-99).
				yyyy - Verify the year as a four-digit number (0000-9999).
				   h - Verify the hour without a leading zero (0-23).
				  hh - Verify the hour with a leading zero (00-23).
				   n - Verify the minute without a leading zero (0-59).
				  nn - Verify the minute without a leading zero (00-59).  
				   s - Verify the second without a leading zero (0-59).
				  ss - Verify the second without a leading zero (00-59). 
			   am/pm - Uses the 12-hour clock for the preceding h or hh specifier, 
			           and verify 'am' for any hour before noon, and 'pm' for any 
					   hour after noon. The am/pm specifier can use lower, upper, 
					   or mixed case, and the result is verified accordingly.
---------------------------------------------------------------------------------------------
*/
function CheckDateTimeFormat(pDateTime, pFormat)
{
  if (pDateTime == "" ||
      pFormat == "")
    return (true);
	
  var
    Format = pFormat.toLowerCase(),
	DateTime = pDateTime.toLowerCase(),
    VerifyIndex = -1,
    ArrayFormats = new Array("am/pm", "dd", "d", "mm", "m", "yyyy", "yy", "hh", "h", "nn", "n", "ss", "s"),
	ArrayVerify = new Array(),
	i = 0, Pos, day = 1, month = 1, year = 2000, hour = 0, minute = 0, second = 0, 
	ampm = "",
	FormatError = "",
	error = false;
    
  while (i < ArrayFormats.length)
  {
    Pos = Format.indexOf(ArrayFormats[i]);	
    if (Pos > -1)
	{	  
	  ArrayVerify[++VerifyIndex] = ArrayFormats[i];
	  Format = Format.substring(0, Pos) + "~" + VerifyIndex + "~" + 
	           Format.substring(Pos + ArrayFormats[i].length, Format.length);
	}
	else
	  i++;
  }
    
  IndexDT = 0;
  IndexFormat = 0;
  while ((IndexFormat < Format.length ||
          IndexDT < DateTime.length) &&
         !error)
  {
    if (IndexFormat >= Format.length ||
	    IndexDT >= DateTime.length)
	{
	  error = true;
	  FormatError = "\nDifferent extensions.";
	}
	else if (Format.charAt(IndexFormat) != "~")
	{
	  error = Format.charAt(IndexFormat++) != DateTime.charAt(IndexDT++);
	  if (error)
	    FormatError = "\nCharacter " + IndexDT + " is invalid.";
	}
	else
	{
	  var
	    Pos = Format.indexOf("~", IndexFormat + 1),
	    Index = parseInt(Format.substring(IndexFormat + 1, Pos), 10),
	    Text = ArrayVerify[Index],
		TextEval, number = "";  

	  if (Text != "am/pm")
	  {
	    if (Text != "yyyy")
		{
		  var c1, c2 = "";
		  
		  c1 = DateTime.charAt(IndexDT);
		  if (IndexDT + 1 < DateTime.length &&
		      DateTime.charAt(IndexDT + 1) != Format.charAt(Pos + 1) &&
			  DateTime.charAt(IndexDT + 1) != " ")
		    c2 = DateTime.charAt(IndexDT + 1);
		  
   	      error = (isNaN(c1)) || (Text.length == 2 && IndexDT + 1 >= DateTime.length) || 
			      (Text.length == 2 && (c2 == "" || isNaN(c2)));
					  
		  if (!error)
		  {
		    number += c1;
			if (c2 != "")
			  number += c2;
			
			if (Text == "d" || Text == "dd")
			  day = parseInt(number, 10)
			else if (Text == "m" || Text == "mm")
			  month = parseInt(number, 10)
			else if (Text == "yy")
			  year = parseInt(number, 10)
			else if (Text == "h" || Text == "hh")
			  hour = parseInt(number, 10)
			else if (Text == "n" || Text == "nn")
			  minute = parseInt(number, 10)
			else if (Text == "s" || Text == "ss")
			  second = parseInt(number, 10)
			  
			IndexFormat = Pos + 1;
			IndexDT += number.length;
		  }	
		  else
		    FormatError = "\nValor for " + Text.toUpperCase() + " is invalid.";	 
		}
		else
		{
		  error = IndexDT + 3 >= DateTime.length || 
		          isNaN(DateTime.substring(IndexDT, IndexDT + 4));
		  if (!error)
		  {
		    year = parseInt(DateTime.substring(IndexDT, IndexDT + 4), 10);
			IndexFormat = Pos + 1;
			IndexDT += 4;
		  }
		  else
		    FormatError = "\nValor for " + Text.toUpperCase() + " is invalid.";	 
		} 
	  }
	  else
	  {
	    error = IndexDT + 1 >= DateTime.length ||
		        (DateTime.substring(IndexDT, IndexDT + 2) != "am" &&
				 DateTime.substring(IndexDT, IndexDT + 2) != "pm");
				
	    if (!error)
		{
		  ampm = DateTime.substring(IndexDT, IndexDT + 2);
		  IndexFormat = Pos + 1;
		  IndexDT += 2;
		}
		else
		  FormatError = "\nValor for " + Text.toUpperCase() + " is invalid.";	 
	  }
	}  
  }  
  
  if (!error)
  {
    if (month > 12 || month < 1)
	  FormatError = "\nMes out of range [1..12].";	 
	
	if (day < 1 || day > 31)
	  FormatError += "\nDia out of range [1..31].";	 
	
	if ((hour < 0 || hour > 23) && ampm == "")
	  FormatError += "\nHour out of range [0..23].";	 

	if (hour > 12 && ampm == "pm")
	  FormatError += "\nHour out of range [0..12] for PM.";	 
	
	if (hour > 11 && ampm == "am")
	  FormatError += "\nHour out of range [0..11] for AM.";	 
	  
	if (minute < 0 || minute > 59)
	  FormatError += "\nMinutes out of range [0..59].";	 
  
  	if (second < 0 || second > 59)
	  FormatError += "\nSeconds out of range [0..59].";	 
	
    if (month > 12 || month < 1 || day < 1 || day > 31 || hour < 0 ||
	    hour > 23 || (hour > 12 && ampm != "") || (hour > 11 && ampm == "am") || 
		minute < 0 || minute > 59 || second < 0 || second > 59) 
	  error = true;
	
	if (!error)
    switch (month)
    {
	  case 2:
	    if (Bisiesto(year))
	    { 
		  if (day > 29) 
		  {
		    error = true;
			FormatError += "\nDia out of range [1..29] for Month " + month + 
			               " for bisiest year " + year + ".";	 
		  }
		}
	    else if (day > 28)
		{
		  error = true;
		  FormatError += "\nDia out of range [1..28] for Month  " + month + ".";	 
		}
	    break;
	  case 4: case 6: case 9: case 11:
	    if (day > 30) 
		{
		  error = true;
		  FormatError += "\nDia out of range [1..30] for Month " + month + ".";	 
		}
	    break;
    }
  }
  
  if (error)
  {
    alert("Invalid Date format " + pFormat.toUpperCase() + "." + FormatError);
	if (event.srcElement != null)
	  event.srcElement.focus();
	return (false);
  }
  else
    return (true);
}

/* 
---------------------------------------------------------------------------------------------           
FUNCTION NAME: 	ValidateDateRange
       AUTHOR:	Cynthia Muñoz
  CREATE DATE: 	08/23/2001 
  DESCRIPTION: 	Validate Date Range returns True if the range is correct and 
                if it is not makes an alert and returns false
                
FUNCTION CALL:  ValidateDateRange("field name 1", date1 in string, "field name 2", date2 in string)
                if (!ValidateDateRange("DA From Date", document.all.Edt_FromDate.value, "DA To Date", document.all.Edt_ToDate.value))  
				  do something
---------------------------------------------------------------------------------------------
*/

function ValidateDateRange(sDateName1, sDate1, sDateName2, sDate2)
{
if (Trim(sDate1) !="" && Trim(sDate2) !="")
   {
	dObjeto1=new Date(sDate1);
	dObjeto2=new Date(sDate2);
	var fDiff = dObjeto1.getTime() - dObjeto2.getTime();
	var iDays = Math.floor(fDiff / (1000 * 60 * 60 * 24));	
	if (iDays > 0)
	   {	    
	     alert(sDateName2 + " cannot be greater than " + sDateName1);
		 return false;
	   }
	}
  return true;
}


/*--------------------------- Key Validations ------------------------------------------*/

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  ValidateKey
       AUTHOR:	Margarita Carbajal
  CREATE DATE: 	15/08/2001 
  DESCRIPTION: 	Validates the key characters according to the type of information you need.
                The parameter is the type of input you want to validate, it could be:
				INTEGER, REALNEG, INTEGERNEG, REAL, DATE, TIME, DATETIME
				For example: in the input write onkeypress="ValidateKey('INTEGER')  
---------------------------------------------------------------------------------------------
*/

function ValidateKey(sType) 
{
	if (sType == "INTEGER") {
		if (( window.event.keyCode < 48) || (window.event.keyCode > 57))
			window.event.keyCode = 0; 
	}

	if (sType == "REALNEG")
	{
		var sStr = window.event.srcElement.value;
		pd = sStr.indexOf(".");
		sMenos = sStr.indexOf("-");
		key = window.event.keyCode;

		if (key == 46)
        {
			if ((pd > -1) || (sStr.length == (sMenos + 1)))
				window.event.keyCode = 0;
		}
		else if (key == 45)
		{
		if ((sMenos > -1) || (sStr.length > 0))
			window.event.keyCode = 0;
		}
		else if (( key < 48) || (key > 57))
			window.event.keyCode = 0;
	} 
	
	if (sType == "INTEGERNEG")
	{
		var sStr = window.event.srcElement.value,
		sMenos = sStr.indexOf("-"),
		key = window.event.keyCode;

		if (key == 45)
		{
			if ((sMenos > -1) || (sStr.length > 0))
				window.event.keyCode = 0;
		}
  		else if (( key < 48) || (key > 57))
    		window.event.keyCode = 0;	
	}
	
    if (sType == "REAL")
	{
		var pd = window.event.srcElement.value.indexOf("."),
		key = window.event.keyCode;

		if (key == 46)
		{
			if ((pd > -1) || (window.event.srcElement.value.length == 0))
				window.event.keyCode = 0;
		}
	else if (( key < 48) || (key > 57))
		window.event.keyCode = 0;
	}
	 
	if (sType == "DATE") 
	{
		if (((window.event.keyCode < 48) || (window.event.keyCode > 57)) && (window.event.keyCode != 47))
			window.event.keyCode = 0
	}     

	if (sType == "TIME")
	{
		if (((window.event.keyCode < 48) || (window.event.keyCode > 57)) && (window.event.keyCode != 58))
			window.event.keyCode = 0
	} 

	if (sType == "DATETIME")
	{
		if (((window.event.keyCode < 48) || (window.event.keyCode > 57)) &&
			(window.event.keyCode != 47) && (window.event.keyCode != 58) && (window.event.keyCode != 32))
			window.event.keyCode = 0   
	}

}


/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  KeyUpperCase
       AUTHOR:	WTS Web
  CREATE DATE: 	6/08/2001 
  DESCRIPTION: 	Change to Upper Case
---------------------------------------------------------------------------------------------
*/
function KeyUpperCase()
{
  if ((window.event.keyCode >= 97) && (window.event.keyCode <= 122))
    window.event.keyCode = window.event.keyCode - 32;
  if (window.event.keyCode >= 209)
    window.event.keyCode = 241;
}


/*--------------------------- onBlur Validations ------------------------------------------
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckNumber
       AUTHOR:	WTS Web
  CREATE DATE: 	16/08/2001 
  DESCRIPTION: 	Verifies if the numbers are correct. This function is called by the other ones.
---------------------------------------------------------------------------------------------
*/


function CheckNumber(str,valid,msg)
{
  if (Trim(str) != "")
  {
    for (var i=0; i < str.length; i++)
      if (valid.indexOf(str.charAt(i)) == -1)
      {
        alert(msg);
        //window.event.srcElement.value = "";
        window.event.srcElement.focus();
        return (false);
      }
  }
  return (true);
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckInteger
       AUTHOR:	WTS Web
  CREATE DATE: 	16/08/2001 
  DESCRIPTION: 	Verifies if the number you entered is integer
---------------------------------------------------------------------------------------------
*/
function CheckInteger(string)
{
  var valid = "0123456789",
  msg = "The value you have enter is not a positive integer number!";
  return (CheckNumber(string,valid,msg));
}


/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckIntegerNeg
       AUTHOR:	WTS Web
  CREATE DATE: 	16/08/2001 
  DESCRIPTION: 	Verifies if the number you entered is integer negative
---------------------------------------------------------------------------------------------
*/
function CheckIntegerNeg(string)
{
  var valid = "0123456789-",
  msg = "The value you have enter is not a integer number!";
  return (CheckNumber(string,valid,msg));
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckReal
       AUTHOR:	WTS Web
  CREATE DATE: 	16/08/2001 
  DESCRIPTION: 	Verifies if the number you entered is real
---------------------------------------------------------------------------------------------
*/
function CheckReal(string)
{
  var valid = "0123456789.",
  msg = "The value you have enter is not a positive real number!";
  return (CheckNumber(string,valid,msg));
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CheckRealNeg
       AUTHOR:	WTS Web
  CREATE DATE: 	16/08/2001 
  DESCRIPTION: 	Verifies if the number you entered is real negative
---------------------------------------------------------------------------------------------
*/
function CheckRealNeg(string)
{
  var valid = "0123456789.-",
  msg = "The value you have enter is not a real number!";
  return (CheckNumber(string,valid,msg));
}

/* 
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  IsEmail
       AUTHOR:	Yehuda Shiran, Ph.D.  -  http://webreference.com/js/tips/990928.html
  CREATE DATE: 	16/08/2001 
  DESCRIPTION: 	Verify if it is a valid email address. It receives the string you entered
---------------------------------------------------------------------------------------------
*/
function IsEmail(str) {
  // are regular expressions supported?
  var supported = 0;
  if (window.RegExp) {
    var tempStr = "a";
    var tempReg = new RegExp(tempStr);
    if (tempReg.test(tempStr)) supported = 1;
  }
  if (!supported) 
    return (str.indexOf(".") > 2) && (str.indexOf("@") > 0);
  var r1 = new RegExp("(@.*@)|(\\.\\.)|(@\\.)|(^\\.)");
  var r2 = new RegExp("^.+\\@(\\[?)[a-zA-Z0-9\\-\\.]+\\.([a-zA-Z]{2,3}|[0-9]{1,3})(\\]?)$");
  return (!r1.test(str) && r2.test(str));
}


/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  WriteHeader
       AUTHOR:	Neil Revilla
  CREATE DATE: 	21/08/2001 
  DESCRIPTION: 	Write header
---------------------------------------------------------------------------------------------
*/

function WriteHeader()
{
// primer parametro debe ser el titulo
// de ahi debe venir en pares el nombre del link y el link
	var arg = WriteHeader.arguments; 
	var sRoot = arg[2];
	var i;
	document.write("<table width='780px' border='0' cellspacing='0' cellpadding='0'>");
//links aqui
	document.write("<tr class='titulo1'>");
	document.write("<td width='354'><img src='"+sRoot+"DW_IMAGES/tit01_02.gif'></td>");
	//document.write("<td bgcolor='#2F4C88' align='right' class='titulo1'>");
    document.write("<td  align='right'>");
	if (arg.length > 4 && (arg.length-1) % 2 == 0)
	{
		for (i=3; i < (arg.length - 1); i=i+2)
		{
			if (i!=3) {document.write("&nbsp;&nbsp;|&nbsp;&nbsp;")}
			document.write("<a target='_self' href='"+arg[i+1] + "?Date=" + (new Date()).valueOf() +"'>");
			document.write("<span class='titulo1'>"+arg[i]+"</span>");
			document.write("</a>");			
		}
	}	
	else
		document.write("&nbsp;");		
    document.write("&nbsp;&nbsp;");
	document.write("</td>");
	document.write("</tr>");
//mensajes aqui
	document.write("<tr>");
	if (arg.length > 1)
	{	
		if (arg[1] != "")		
			document.write("<td><img src='"+sRoot+"DW_IMAGES/" + arg[1] +"'  ></td>")
		else
			document.write("<td bgcolor='#00ADEF'>&nbsp;</td>");	
	}	
	document.write("<td bgcolor='#00ADEF' align='right' class='titulo2'>");

	if (arg.length > 0)
		document.write(arg[0]+"&nbsp;&nbsp;")
	else
		document.write("&nbsp;");
	document.write("</td>");
	document.write("</tr>");
//linea dorada
	document.write("<tr style='height: 5px' bgcolor='#F9F402' >");
	document.write("<td colspan='2'></td>");
	document.write("</tr>");
	document.write("</table>");
}


/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  ReplaceText
       AUTHOR:	WTS Web
  CREATE DATE: 	23/08/2001 
  DESCRIPTION:  Replace text in the URL.
---------------------------------------------------------------------------------------------
*/

function ReplaceText(string)
{
  var result = "";
  for (var i=0; i < string.length; i++)
  {
    if (string.charAt(i) == " ") result += "%20"
    else if (string.charAt(i) == "!") result += "%21"
    else if (string.charAt(i) == "\"") result += "%22"
    else if (string.charAt(i) == "#") result += "%23"
    else if (string.charAt(i) == "%") result += "%24"
    else if (string.charAt(i) == "&") result += "%26"
    else if (string.charAt(i) == "@") result += "%40"
    else result += string.charAt(i);
  }
  return (result);
}

function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_preloadImages() { //v3.0
  var d=document; if(d.Images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_findObj(n, d) { //v4.0
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && document.getElementById) x=document.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  blockBackSpace
       AUTHOR:	CPSP Web
  CREATE DATE: 	27/10/2001
  DESCRIPTION:  Block Back effect when pressing Backspace over select.
---------------------------------------------------------------------------------------------
*/

function blockBackSpace(){
  if (event.keyCode==8)
    event.returnValue = false;
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  block Search Invalid Characters
       AUTHOR:	CPSP Web
  CREATE DATE: 	27/10/2001
  DESCRIPTION:  Block invalid characters like "'" and "%".
---------------------------------------------------------------------------------------------
*/

function blockSearchInvalidChars()
{
  if ((event.keyCode==34) || (event.keyCode==44) || (event.keyCode==37) || (event.keyCode==39) || (event.keyCode==95))
    event.returnValue = false;
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  FORMAT VALUE
       AUTHOR:	CPSP Web
  CREATE DATE: 	31/10/2001
  DESCRIPTION:  Format the decimals of a Number 
---------------------------------------------------------------------------------------------
*/

function formatDecimal(argvalue, addzero, decimaln) 
{
 //Especifica un formato para la cadena
  var numOfDecimal = (decimaln == null) ? 2 : decimaln;
  var number = 1;

  number = Math.pow(10, numOfDecimal);

  argvalue = Math.round(parseFloat(argvalue) * number) / number;
  // If you're using IE3.x, you will get error with the following line.
  // argvalue = argvalue.toString();
  // It works fine in IE4.
  argvalue = "" + argvalue;

  if (argvalue.indexOf(".") == 0)
    argvalue = "0" + argvalue;

  if (addzero == true) {
    if (argvalue.indexOf(".") == -1)
      argvalue = argvalue + ".";

    while ((argvalue.indexOf(".") + 1) > (argvalue.length - numOfDecimal))
      argvalue = argvalue + "0";
  }

  return argvalue;
}

/*Call this function to use it*/
function formatValue(argvalue, format) 
{
  var numOfDecimal = 0;
  if (format.indexOf(".") != -1) 
  {
    numOfDecimal = format.substring(format.indexOf(".") + 1, format.length).length;

  argvalue = formatDecimal(argvalue, true, numOfDecimal);

  argvalueBeforeDot = argvalue.substring(0, argvalue.indexOf("."));
  retValue = argvalue.substring(argvalue.indexOf("."), argvalue.length);

  strBeforeDot = format.substring(0, format.indexOf("."));

  for (var n = strBeforeDot.length - 1; n >= 0; n--) {
    oneformatchar = strBeforeDot.substring(n, n + 1);
    if (oneformatchar == "#") {
      if (argvalueBeforeDot.length > 0) {
        argvalueonechar = argvalueBeforeDot.substring(argvalueBeforeDot.length - 1, argvalueBeforeDot.length);
        retValue = argvalueonechar + retValue;
        argvalueBeforeDot = argvalueBeforeDot.substring(0, argvalueBeforeDot.length - 1);
      }
    }
    else {
      if (argvalueBeforeDot.length > 0 || n == 0)
        retValue = oneformatchar + retValue;
    }
  }
 } else retValue = argvalue

 return retValue;
}

/*Function que valida campos mandatorios, recibe un string como parametro */
/*Formato del string: "Edt_FieldName|'Field Label'";*/
function validMandatoryFields(strMandatoryFields)
{
  var Fields, oField, nameField, descField, nf;
  var msg="", ENTER="\r\n\t - ";
  Fields = strMandatoryFields.split("||");
  nf = Fields.length;  

  for (var i=0; i < nf; i++) {
    oField = Fields[i].split("|");
    nameField = document.all(oField[0]);
	descField = oField[1];
    if (nameField.value == "")
	  msg = msg + ENTER + descField;
  }
  if (msg != "") {
    alert("The following information is mandatory: "+ msg);
	return false;
  }
  else return true; 
}

/*Function que valida campos mandatorios para campos que utilizan mas de un componente, 
  recibe un string como parametro */
/*Formato del string: "Edt_FieldName1&&Edt_FieldName2|'Field Label'";
                       "Edt_Name|'Name'||"+  
		       "Edt_Address_1&&Edt_Address_2&&Edt_Address_3|'Address'||"+
		       "Edt_City|'City'";
*/
function validMandatoryFields2(strMandatoryFields)
{
  var Fields, oFields, namesField, components, componentsName, descField, nf, nc;
  var msg="", ENTER="\r\n\t - ";
		var notValid;
		
  Fields = strMandatoryFields.split("||");
  nf = Fields.length;  

  for (var i=0; i < nf; i++) 
		{
    oFields = Fields[i].split("|");
				
				componentsName =  oFields[0].split("&&");
    descField = oFields[1];
				
				notValid = true;
				nc = componentsName.length;  
				for (var j=0; j< nc; j++)
				{
				  component = document.all(componentsName[j]);
						notValid = notValid && (Trim(component.value) == "");
				}				
				
    if (notValid)
	     msg = msg + ENTER + descField;
  }
  if (msg != "") 
		{
    alert("The following information is mandatory: "+ msg);
   	return false;
  }
  else return true; 
}
/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  CHECK LENGTH
       AUTHOR:	CPSP Web
  CREATE DATE: 	31/10/2001
  DESCRIPTION:  Check Input length 
---------------------------------------------------------------------------------------------
*/

function  checkLength(pValue,pMaxLength)
{
  if (pValue.length >= pMaxLength)
  {
   event.returnValue = false;
  }
}

/*
<---------------------------------------------------------------------------------------------           
FUNCTION NAME:  ENABLE CONTROLS
       AUTHOR:	Enrique Bassallo H.
  CREATE DATE: 	07/06/2002
  DESCRIPTION:  Enabled components for grids associated with XML. 
  				For images must be QueryButton2 class. 
				pComponentList is a List of Component Names.
---------------------------------------------------------------------------------------------
*/

function EnableControls(pDocument, pXML, pComponentList)
{
  var value = (pXML == null || pXML.recordset.RecordCount == 0) ;
  
  for (var i = 0; i < pComponentList.length; i++)
  {
    var obj = pDocument.all(pComponentList[i]);
	
	if (obj != null)
	{
	  if (obj.tagName.toLowerCase() == "img")
	  {
	    if (!value) 
	      obj.setEnable()
	    else
	      obj.setDisable();
	  }
	  else if (obj.tagName.toLowerCase() == "select" && 
	           obj.className.toLowerCase().indexOf("readonly") == -1)
	    obj.disabled = value	
	  else if (obj.type.toLowerCase() == "button")
	    obj.disabled = value
	  else if (obj.className.toLowerCase().indexOf("readonly") == -1)
	    obj.readOnly = value;
	}	
  }  
}
