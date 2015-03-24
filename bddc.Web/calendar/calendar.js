var startDate;
var startTime;
var okFunction;
var displayCalendar;
var displayTime;
var PickerPath="";		

function showCalendar(startDate,startTime,okFunction,displayCalendar,displayTime){
  var x =  startDate;
  if (x != '')
	window.startDate = x.substring(3,5) + '/' + x.substring(0,2) + '/' + x.substring(6,10);
  else
    window.startDate = x;		
  
  window.startTime = startTime;
  window.okFunction = okFunction;
  window.displayCalendar = displayCalendar;
  window.displayTime = displayTime;
  var height="";  
  var urlString = PickerPath+"../calendar/datetimepicker.html";
  
  if (displayCalendar && displayTime) height="280";
  if (displayCalendar && !displayTime) height="230";
  if (!displayCalendar && displayTime) height="100";

  window.showModalDialog(urlString,window,"dialogHeight:"+height+"px;dialogWidth:220px;dialogTop:270px;dialogLeft:270px;status:0;help:0");
}

function datePicker(editDate){
 showCalendar(editDate.value,'',function(strDate,strTime){editDate.value = strDate},true,false)
}

function datetimePicker(editDate,editTime){
 if (editTime==null) {
   var tokens = editDate.value.split(" ");
   var iniDate='';
   var iniTime=''; 
   if (tokens.length>=1) iniDate = tokens[0];
   if (tokens.length==2) iniTime = tokens[1];
   showCalendar(iniDate,iniTime,function(strDate,strTime){editDate.value = strDate+ ' '+strTime},true,true)
 }
 if (editTime!=null) {
   showCalendar(editDate.value,editTime.value,function(strDate,strTime){editDate.value = strDate; editTime.value=strTime},true,true)
 }   
}

function timePicker(editTime){
 showCalendar('',editTime.value,function(strDate,strTime){editTime.value = strTime},false,true)
}

function getDateTime(pDateTimeField,withDate,withTime)
{  		
  var returnDateTimeField=null;
  var iniDate='';
  var iniTime=''; 
    
  function setDateTime(date,time)
  {  	
	if (time!="")
	returnDateTimeField.value = date+" "+time;
	else 
	{	//hr=new Date(date);
		//NewDate=hr.getDate()+"/"+eval(hr.getMonth()+1)+"/"+hr.getYear();
		//returnDateTimeField.value = NewDate;
		returnDateTimeField.value = date;
	}
  }
  returnDateTimeField = pDateTimeField;

  /*if ((!pDateTimeField.readOnly) && (!pDateTimeField.disabled))
  {*/
  var tokens = pDateTimeField.value.split(" ");
  if (tokens.length>=1) iniDate = tokens[0];
  if (tokens.length==2) iniTime = tokens[1];  
  showCalendar(iniDate,iniTime,setDateTime,withDate,withTime);
  
  //pDateTimeField.focus();
  //}

}

function getDateTimeValid(pDateTimeField,withDate,withTime, MinDate)
{  
  var returnDateTimeField=null;
  var iniDate='';
  var iniTime=''; 
  
  function setDateTime(date,time)
  {  	
	if (time!="")
	returnDateTimeField.value = date+" "+time;
	else returnDateTimeField.value = date;
  }
  returnDateTimeField = pDateTimeField;

  if ((!pDateTimeField.readOnly) && (!pDateTimeField.disabled))
  {
  var tokens = pDateTimeField.value.split(" ");
  if (tokens.length>=1) iniDate = tokens[0];
  if (tokens.length==2) iniTime = tokens[1];  +
  
  showCalendar(iniDate,iniTime,setDateTime,withDate,withTime);
  if (MinDate!='')
	{
		if (pDateTimeField.value<MinDate )
			{
				pDateTimeField.value=''
				alert("La fecha debe ser mayor o igual a " +MinDate );		
				//getDateTimeValid(pDateTimeField,withDate,withTime,MinDate);
			}
		else
				pDateTimeField.focus();
	}
   else
  		pDateTimeField.focus();
  }
}

function Valid(pDateTimeField, MinDate)
{  
	if (pDateTimeField.value<MinDate)
			{
				pDateTimeField.value=''
				alert("La fecha de fin debe ser mayor o igual a " +MinDate );		
				pDateTimeField.focus();
			}
}