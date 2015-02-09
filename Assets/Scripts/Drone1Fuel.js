// TIMER counting UP
var timer : float = 0.0;
var timerMax : float = 3.0;
function Update()
{
timer += Time.deltaTime;
 
if (timer >= timerMax)
{
Debug.Log("timerMax reached !");
 
// reset timer
timer = 0;
}
}
