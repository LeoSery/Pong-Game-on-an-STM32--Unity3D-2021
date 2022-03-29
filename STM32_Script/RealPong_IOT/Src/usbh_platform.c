#include "usbh_platform.h"

void MX_DriverVbusFS(uint8_t state)
{
  uint8_t data = state;
 
  if(state == 0)
  {   
    data = GPIO_PIN_RESET;
  }
  else
  {
    data = GPIO_PIN_SET;
  }
 
  HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,(GPIO_PinState)data);
}
