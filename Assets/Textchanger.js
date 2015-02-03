var inputkey1 = "1";
var inputkey2 = "2";
var inputkey3 = "3";
var inputkey4 = "4";
var inputmessage1 = "Dont Put the same inputer key in twice";
var inputmessage2 = "or it will print both lines at once!";
var inputmessage3 = "This is what inputkey3 will say!";
var inputmessage4 = "This is what inputkey4 will say!";
private var gt : GUIText;
function Start()
{  gt = GetComponent(GUIText);
     if( gt == null ) Debug.Log("No GUIText component found");
}

function Update ()
{
   if(Input.GetKeyDown(inputkey1))
   { print ( inputmessage1 );
      gt.text = inputmessage1; }
    
   else if(Input.GetKeyDown(inputkey2))
   { print ( inputmessage2 ); 
    gt.text = inputmessage2; }
   
   else if(Input.GetKeyDown(inputkey3))
   { print ( inputmessage3 ); 
    gt.text = inputmessage3; }
   
   else if(Input.GetKeyDown(inputkey4))
   { print ( inputmessage4 );
    gt.text = inputmessage4; }
}