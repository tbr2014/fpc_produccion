Calendar.prototype.LoadCalendar=oLoadCalendar;
Calendar.prototype.PrepareCalendar=oPrepareCalendar;
Calendar.prototype.setTable=osetTable;
Calendar.prototype.cellClick=ocellClick;
Calendar.prototype.cellDblClick=ocellDblClick;
Calendar.prototype.tableCalendar=null;
Calendar.prototype.loadTable=false;

function Calendar(pTable) {
  this.tableCalendar=pTable;
  this.setTable();
  this.tableCalendar.InitialDay="";
  this.tableCalendar.CurrentDate="";
  return this;
}

function oLoadCalendar(startMonth,startYear) {
var start=startMonth+"/01/"+startYear;
var end=eval(startMonth)+1+"/01/"+startYear;
  var startdt = new Date(start);
  var enddt = new Date(end);
  var startVisibleDay=startdt.getDay();
  var endVisibleDay=enddt.getDay();
  var dayCount=0;
 this.PrepareCalendar();

  if (this.tableCalendar.CurrentDate.indexOf("/")>0) this.tableCalendar.CurrentDate="";

  for (var i=1;i<7;i++) {
    for (var j=startVisibleDay;j<7;j++) {
      if ((dayCount>=28) && (j==endVisibleDay)) return;
      else dayCount++;
      this.tableCalendar.rows(i).cells(j).innerText=dayCount;
      this.tableCalendar.rows(i).cells(j).id=formatNumber(dayCount)+"/"+formatNumber(startMonth)+"/"+formatNumber(startYear);
      //this.tableCalendar.rows(i).cells(j).id=formatNumber(startMonth)+"/"+formatNumber(dayCount)+"/"+formatNumber(startYear);
	  if (dayCount==eval(this.tableCalendar.InitialDay)) {
        this.tableCalendar.rows(i).cells(j).bgColor= "#0000FF" //"#a6d3a5"
        //"#B0C4DE";
        this.tableCalendar.rows(i).cells(j).style.color="#FFFFFF";
        this.tableCalendar.CurrentDate=this.tableCalendar.rows(i).cells(j).id;
	  }
    }
    startVisibleDay=0;
  }
}

function oPrepareCalendar() {
  if (!this.loadTable) this.setTable();
 
  for (var i=1;i<7;i++) {
    for (var j=0;j<7;j++) {    
      this.tableCalendar.rows(i).cells(j).style.fontFamily="Arial";
      this.tableCalendar.rows(i).cells(j).style.fontSize="9pt";     
      if (j==0) this.tableCalendar.rows(i).cells(j).style.color="#000000";
      this.tableCalendar.rows(i).cells(j).style.cursor='hand';
      this.tableCalendar.rows(i).cells(j).innerText=" ";
      this.tableCalendar.rows(i).cells(j).id="";
      this.tableCalendar.rows(i).cells(j).onclick=this.cellClick;
      this.tableCalendar.rows(i).cells(j).ondblclick=this.cellDblClick;
    }
  }
  UnHighlightCalendar(this.tableCalendar);  
}

function osetTable() {
  var Days = new Array("D","L","M","M","J","V","S");
  
  for (var i=0;i<7;i++) {
    Row=this.tableCalendar.insertRow();
    for (var j=0;j<7;j++) {
      Cell = Row.insertCell();
      Cell.width="14%";
      Cell.style.fontFamily="Arial";
      Cell.style.fontSize="8pt";
      Cell.align="center";
      if (i==0) {
        if (j==0) Cell.bgColor= "Navy" //"#7ca97b"
        //Cell.bgColor="#006699"
             else Cell.bgColor="Navy" //"#7ca97b";
        Cell.style.color="#FFFFFF";
        Cell.innerText=Days[j];
      }
      else {
        if (j==0) Cell.bgColor= "#0000FF"//"#7ca97b"
        else Cell.bgColor="#C0C0C0";
        Cell.innerHTML="&nbsp;";
      }
    }
  }
  this.loadTable=true;
  this.tableCalendar.setAttribute("InitialDay");
  this.tableCalendar.setAttribute("CurrentDate");
}

function UnHighlightCalendar(tableCalendar) {
  for (var i=1;i<7;i++)
    for (var j=0;j<7;j++) {    
      tableCalendar.rows(i).cells(j).bgColor="#CCCCCC"; //#E9E9E9
      tableCalendar.rows(i).cells(j).style.color="#000000";
      if (j==0) {
        tableCalendar.rows(i).cells(j).bgColor="Navy"; //#7ca97b        //"#006699";
        tableCalendar.rows(i).cells(j).style.color="#FFFFFF";
      }
    }
}

function ocellClick() {
   if (window.event.srcElement.innerText!=" ") {
     var table = window.event.srcElement.parentElement.parentElement.parentElement;
     UnHighlightCalendar(table);
     window.event.srcElement.bgColor= "#0000FF" //"#a6d3a5";      //"#B0C4DE";
     window.event.srcElement.style.color="#FFFFFF" // "#000000";
     table.CurrentDate=window.event.srcElement.id;
   }
}

function ocellDblClick() {
  btnOK.click();
}

function formatNumber(number) {
  if (number<10) return "0"+number;
            else return number;
}

function setInitialDate(startDate,table,month,year) {
  if (startDate=="" || startDate == null) {
    hr=new Date();
   //startDate=hr.getDate()+"/"+eval(hr.getMonth()+1)+"/"+hr.getYear();
   startDate=eval(hr.getMonth()+1)+"/"+hr.getDate()+"/"+hr.getYear();
  }
  var tokens = startDate.split("/");
	month.value=eval(tokens[0]);
    table.InitialDay=eval(tokens[1]);
    year.value=eval(tokens[2]);
}

function setInitialTime(startTime,hour,minute,second) {
  if (startTime=="" || startTime == null) { 
    hr=new Date();
    startTime=hr.getHours()+":"+hr.getMinutes()+":"+hr.getSeconds();
  }
  var tokens = startTime.split(":"); 
  hour.value = eval(tokens[0]);
  minute.value = eval(tokens[1]);
//  second.value = eval(tokens[2]);  
}

function populateCalendar() {
  //Months=new Array("January","February","March","April","May","June","July","August","September","October","November","December");
  Months=new Array("Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Setiembre","Octubre","Noviembre","Diciembre");
  Years=new Array();
  dt = new Date();
  startYear = 1950;
  endYear=dt.getYear() + 1 + 1;
  for (var i=0;i<(endYear-startYear);i++) Years[i]=startYear+i;
  for (var i=0;i<Months.length;i++) {
    var oOption = document.createElement("OPTION");
    document.all.month.add(oOption);
    oOption.value = i+1;
    oOption.innerText = Months[i];
  }
  for (var i=0;i<Years.length;i++) {
    var oOption = document.createElement("OPTION");
    document.all.year.add(oOption);
    oOption.value = Years[i];
    oOption.innerText = Years[i];
  }
}

function populateTime() {
  for (var i=0;i<24;i++) {
    var oOption = document.createElement("OPTION");
    document.all.hour.add(oOption);
    oOption.value = i;
    oOption.innerText = formatNumber(i);
  }	 
  for (var i=0;i<60;i++) {
    var oOptionM = document.createElement("OPTION");
    var oOptionS = document.createElement("OPTION");
    document.all.minute.add(oOptionM);
//    document.all.second.add(oOptionS);
    oOptionM.value = i;
    oOptionM.innerText = formatNumber(i);
    oOptionS.value = i;
    oOptionS.innerText = formatNumber(i);
  }
}

function buildCalendar(startDate,startTime,showCalendar,showTime) {
  if (showCalendar) {
      populateCalendar();
     cal = new Calendar(tableCalendar);
     setInitialDate(startDate,tableCalendar,month,year); 
     
     cal.LoadCalendar(month.value,year.value);
  }	 

  if (showTime) {
     populateTime();
     setInitialTime(startTime,hour,minute);  
//     setInitialTime(startTime,hour,minute,second);  	 
  }
}

function doOkClick(resultDate,resultTime) {
  this.objWindowParent.okFunction(resultDate,resultTime);
 
  this.oContainer.style.display = 'none';
  this.oContainer.innerHTML = "";
  window.event.cancelBubble = true;
  window.close();
}

function createCalendar() {
  this.objWindowParent = window.dialogArguments; 
  if (this.objWindowParent == null)
    this.objWindowParent = window.opener;
  this.doOkClick = doOkClick;
  this.oContainer = spanCalendar;  
  this.oContainer.style.width = 194;
//  this.oContainer.style.borderWidth = '1px';
//  this.oContainer.style.borderStyle = 'solid';
//  this.oContainer.style.backgroundColor = '#C9CDCA';
  this.oContainer.style.display = "";
  var textHtml = "";
  if (this.objWindowParent.displayCalendar) {
	 textHtml = textHtml +  "<table border='0' cellspacing='3' cellpadding='0' width='180'>" +
	                        "<tr>" +
	                        " <td width='91' align='left'><select size='1' id='month' name='month' style='font-family: Arial; font-size: 8 pt' onChange='cal.LoadCalendar(month.value,year.value)'>" +
	                        " </select></td>" +
	                        " <td width='86' align='right'><select size='1' id='year' name='year' style='font-family: Arial; font-size: 8 pt' onChange='cal.LoadCalendar(month.value,year.value)'>" +
	                        " </select></td>" + 
	                        "</tr>" +
	                        "</table>" +
//	                        "<p style='word-spacing: 0; margin-left: 0; margin-right: 0; margin-top: 6; margin-bottom: 6'></p>" +
	                        "<table id='tableCalendar' border='0' width='180' cellspacing='3' cellpadding='0'>" +
	                        "</table>";
  }
  if (this.objWindowParent.displayTime) {
     textHtml = textHtml +  "<table border=0 width=180 cellspacing=3 cellpadding=0>" +
		    				" <tr bgcolor=#839d88 align='center' style='color: #FFFFFF;'>" +
		      				"  <td width=50%><font face=Arial size=1>Hours</font></td>" +
		      				"  <td width=50%><font face=Arial size=1>Minutes</font></td>" +
		      				"  <!--<td width=34%><font face=Arial size=1>Seconds</font></td>-->" +
		    				" </tr>" +
		  					"</table>" +
		  					"<table border=0 width=180 cellspacing=3 cellpadding=0>" +
		    				" <tr>" +
		      				"  <td width=40%><font face=Arial size=1>" +
		  	 				"  <p align=center><select size=1 name=hour style='font-family: Arial; font-size: 8 pt'></select></font></p></td>" +
		      				"  <td width=20%><p align=center><font face=Arial size=2><b>:</b></font></p></td>" +
		      				"  <td width=40%><font face=Arial size=1>" +
		  	 				"   <select size=1 name=minute style='font-family: Arial; font-size: 8 pt'></select></font></td>" +
		      				"  <!--<td width=20%><p align=center><font face=Arial size=2><b>:</b></font></td>-->" +
		      				"  <!--<td width=20%><font face=Arial size=1>-->" +
		  	 				"   <!--<select size=1 name=second style='font-family: Arial; font-size: 8 pt'></select></font></td>-->" +
		    				" </tr>" +
		  					"</table>";							
  }
  var resultDate="''";
  var resultTime="''";
 
  if (this.objWindowParent.displayCalendar) {
  resultDate="tableCalendar.CurrentDate";

  }
//Barnet cambiar el de abajo  if (this.objWindowParent.displayTime) resultTime="formatNumber(hour.value)+':'+formatNumber(minute.value)";
  if (this.objWindowParent.displayTime) resultTime="formatNumber(hour.value)+':'+formatNumber(minute.value)+':'+formatNumber(second.value)";  

  textHtml = textHtml +
             "<p style='word-spacing: 0; margin-left: 0; margin-right: 0; margin-top: 6; margin-bottom: 6'></p>" +
  			 "<input type='button' name='btnOK' value='OK' style='border-style:solid; border-width:1px; border-color:#666666; width=180; height=20; font-family: Arial; font-size: 7 pt'" +
			 "onClick= doOkClick("+resultDate+","+resultTime+")>";

  this.oContainer.innerHTML = textHtml;
  buildCalendar(this.objWindowParent.startDate,this.objWindowParent.startTime,this.objWindowParent.displayCalendar,this.objWindowParent.displayTime);
}
