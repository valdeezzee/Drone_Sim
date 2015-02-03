#pragma strict
 
// JavaScript
 
var backgroundTexture : Texture;
var foregroundTexture : Texture;
var frameTexture : Texture;
 
var drone1FuelWidth: int = 199;
var drone1FuelHeight: int = 30;
 
var drone1FuelMarginLeft: int = 41;
var drone1FuelMarginTop: int = 38;
 
var frameWidth : int = 266;
var frameHeight: int = 65;
 
var frameMarginLeft : int = 10;
var frameMarginTop: int = 10;
var x = 1;
/*
function changeNum()
{
	if(x==1)
		drone1FuelWidth = (-500)
}
 */
 /*
public GameObject UAV;
public GameObject UAV;
 public GameObject UAV;
 public GameObject UIElement;
 public GameObject UIElement;
 public GameObject UIElement;
 UIElement = GetComponent<RectTransform>();
 UIElement.z =  UAV.transform.rotation.y;
 */
 
function OnGUI () {

 	
    GUI.DrawTexture( Rect(frameMarginLeft,frameMarginTop, frameMarginLeft + frameWidth, frameMarginTop + frameHeight), backgroundTexture, ScaleMode.ScaleToFit, true, 0 );
 
    GUI.DrawTexture( Rect(drone1FuelMarginLeft,drone1FuelMarginTop,drone1FuelWidth + drone1FuelMarginLeft, drone1FuelHeight), foregroundTexture, ScaleMode.ScaleAndCrop, true, 0 );
 
    GUI.DrawTexture( Rect(frameMarginLeft,frameMarginTop, frameMarginLeft + frameWidth,frameMarginTop + frameHeight), frameTexture, ScaleMode.ScaleToFit, true, 0 );
 
 	
}