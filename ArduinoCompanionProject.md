# Hardware #

  * Tamiya Twin Motor Gearbox
  * Tamiya Track & Wheel Set
  * Tamiya Universal Plate Set
  * L298N Dual H-Bridge motor driver
  * Arduino Leonardo
  * HC-06 Serial Bluetooth Transciever Module

  * LG Optimus One, acting as an IP Camere for the MJPEG Stream

# Source Code #

```
/*
Created by: Kovács Gellért Pál
License: Apache V2 http://www.apache.org/licenses/LICENSE-2.0.html

This program drives a vehicle, getting the data 
through a serial port and interpriting it.

C# control application available at: https://code.google.com/p/mjpeg-bluetooth-arduino-vehicle/
*/

#define LEFT1 5    //left motor FORWARD pin
#define LEFT2 6    //left motor backward pin
#define RIGHT1 11  //right motor FORWARD pin
#define RIGHT2 13  //right motor backward pin

//constants helping to make the code more readable
//they are named according to the same pattern in the C# WinForms
//companion project
#define FORWARD     1
#define BACKWARD    2
#define RIGHT       3
#define LEFT        4
#define FWD_RIGHT   5
#define FWD_LEFT    6
#define BWD_RIGHT   7
#define BWD_LEFT    8
#define STOP        0

//time in milliseconds to wait before checking for new command
#define LOOP_DELAY  20



void setup()
{
    //initialize motor pins
    pinMode(LEFT1, OUTPUT);
    pinMode(LEFT2, OUTPUT);
    pinMode(RIGHT1, OUTPUT);
    pinMode(RIGHT2, OUTPUT);
    
    //start serial bluetooth communication at 9600 bits/sec rate    
    Serial1.begin(9600);    
}

void loop()
{
    if (Serial1.available()) //new command arrived
    {
      int incomingCommand = Serial1.read();
      int Speed = incomingCommand % 10; // last digit of command
      int Direction = incomingCommand / 10; //first digit of command
      
      //convert Speed into valid 8bit PWM data
      int PWM_Speed = map(Speed, 1, 9, 60, 255);
      
      //controlling the motor voltage according to
      //the incoming command
      switch (Direction)
      {        
        case STOP:        analogWrite(LEFT1, 0);
                          analogWrite(LEFT2, 0);
                          analogWrite(RIGHT1, 0);
                          analogWrite(RIGHT2, 0); 
                          break;
        //***************************************************
        case FORWARD:     analogWrite(LEFT1, PWM_Speed);
                          analogWrite(LEFT2, 0);
                          analogWrite(RIGHT1, PWM_Speed);
                          analogWrite(RIGHT2, 0);
                          break;
        //***************************************************
        case BACKWARD:    analogWrite(LEFT1, 0);
                          analogWrite(LEFT2, PWM_Speed);
                          analogWrite(RIGHT1, 0);
                          analogWrite(RIGHT2, PWM_Speed);
                          break;
        //***************************************************
        case RIGHT:      analogWrite(LEFT1, 0);
                          analogWrite(LEFT2, PWM_Speed);
                          analogWrite(RIGHT1, PWM_Speed);
                          analogWrite(RIGHT2, 0);
                          break;
        //***************************************************
        case LEFT:        analogWrite(LEFT1, PWM_Speed);
                          analogWrite(LEFT2, 0);
                          analogWrite(RIGHT1, 0);
                          analogWrite(RIGHT2, PWM_Speed);
                          break;
        //***************************************************
        case FWD_RIGHT:   analogWrite(LEFT1, 0);
                          analogWrite(LEFT2, 0);
                          analogWrite(RIGHT1, PWM_Speed);
                          analogWrite(RIGHT2, 0);
                          break;
        //***************************************************
        case BWD_RIGHT:   analogWrite(LEFT1, 0);
                          analogWrite(LEFT2, 0);
                          analogWrite(RIGHT1, 0);
                          analogWrite(RIGHT2, PWM_Speed);
                          break;
        //***************************************************
        case FWD_LEFT:    analogWrite(LEFT1, PWM_Speed);
                          analogWrite(LEFT2, 0);
                          analogWrite(RIGHT1, 0);
                          analogWrite(RIGHT2, 0);
                          break;
        //***************************************************
        case BWD_LEFT:    analogWrite(LEFT1, 0);
                          analogWrite(LEFT2, PWM_Speed);
                          analogWrite(RIGHT1, 0);
                          analogWrite(RIGHT2, 0);
                          break;
      }      
    }
    
    //wait for LOOP_DELAY milliseconds before checking for new command
    //value of LOOP_DEALY can be changed at the beginning of the code
    delay(LOOP_DELAY);
}
```