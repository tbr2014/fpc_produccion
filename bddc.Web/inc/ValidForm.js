//Numeros Aleatorios:
function aleatorio(inferior,superior)
{ 
    numPosibilidades = superior - inferior;
    aleat = Math.random() * numPosibilidades;
    aleat = Math.round(aleat);
    return parseInt(inferior) + aleat ;
} 

function GenerarClave(objName)
{
    numaleat = aleatorio(10000000, 99999999);
    //alert(numaleat);
    document.getElementById(objName).value = numaleat;
}


// Funciones para DataGrid:

function highlightRow(objOver) {
				var objTR = objOver.parentElement.parentElement;
				objTR.className = objTR.className + "Selected";
			}
			
			function unhighlightRow(objOver) {
				var objTR = objOver.parentElement.parentElement;
				objTR.className = objTR.className.substring(0, objTR.className.length - 8);
			}

// *****			
			
function CurrencyFormatted(amount)
		{
			var i = parseFloat(amount);
			if(isNaN(i)) { i = 0.00; }
			var minus = '';
			if(i < 0) { minus = '-'; }
			i = Math.abs(i);
			i = parseInt((i + .005) * 100);
			i = i / 100;
			
			var s = new String(i);
			if(s.indexOf('.') < 0) { s += '.00'; }
			if(s.indexOf('.') == (s.length - 2)) { s += '0'; }
			s = minus + s;
			
			return s;
		}


function soloNumeros(evt) 
{ 
	var charCode = (evt.which) ? evt.which : event.keyCode;

	//alert(charCode);				

	if  (charCode == 8) return true; // Espacio
	if (charCode > 31 && (charCode < 48 || charCode > 57) && charCode != 46 && charCode != 45 ) 
	{ 
		alert("Solo se permiten NUMEROS en este campo."); 					
		return false; 
	} 								
	return true; 
} 	

function soloLetras(evt) 
{ 	
	alert(':)');				
	
	var charCode = (evt.which) ? evt.which : event.keyCode;	

	if  (charCode == 8) return true; // Espacio
	if ( (charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 91) || charCode == 123 ) 
		return true; 		
	else
	{
		alert("Solo se permiten LETRAS en este campo."); 					
		return false; 
	}	 								
	
} 	

function IsNumeric(sText)
{
   var ValidChars = "0123456789.";
   var IsNumber=true;
   var Char;
   var numPoints =0;
 
   for (i = 0; i < sText.length && IsNumber == true; i++) 
      { 
      Char = sText.charAt(i); 
      //alert(Char);
      if (Char == '.') numPoints++;            
      if (ValidChars.indexOf(Char) == -1 || numPoints > 1) 
         {
         IsNumber = false;
         }
      }
   return IsNumber;
   
   }

	function SetControles()
	{
		document.getElementById("lblMensaje").innerText = "";
		/*
		validateEntidadAhorro();	
		validateEntidadAuxiliar();
		validateEntidadComplementaria();
		validateEntidadComplementariaAuxiliar();				
		*/
		totalAhorro();
	}
	
	function ConvCaps(evt)
	{
			evt = (evt) ? evt : event; 
				var charCode = (evt.charCode) ? evt.charCode : ((evt.keyCode) ? evt.keyCode : 
					((evt.which) ? evt.which : 0)); 					
				if (charCode >= 97 && charCode <= 122) { 
					evt.keyCode= charCode - 32
					return true; 
				} 								
				return true; 
	
	
		/*document.getElementById(sControl).value=document.getElementById(sControl).value.toUpperCase();*/
	}

	function changeStyle(obj, type)	
	{
		var objName = obj.name;
		var objControl = document.getElementById(objName);
		 
		//alert(objControl.style.color);		
		//alert(type);
		
		switch(type)
		{
			case 'onfocus':
			{
				objControl.style.color = "navy";
				objControl.style.background = "papayawhip";
				break;
			}
			case 'onblur':
			{
				objControl.style.color = "";
				objControl.style.background = "ghostwhite";
				objControl.className = "GNRtxtInputNavy";
				break;
			}
		};
		
		//objControl.style.color = "";
		//objControl.style.background = "lightyellow";
	}
	
	function setUbicacion(obj) 
	{
		var ubic = document.getElementById("ddlUbicacion");
		
		//alert(obj.value);
		
		ubic.disabled=true;
		if (obj.value == "1") ubic.disabled=false;			    
			    			
	}
	
	function MarcarHoras(obj)
	{
		var hora, nombre; 
		
		for (k=0; k<24; k++)
		{
			nombre = "chklstHorario_" + k;
			//alert(nombre);
			hora = document.getElementById(nombre);
			hora.checked = obj.checked
		}
		//alert(hora.checked);
		
	}
