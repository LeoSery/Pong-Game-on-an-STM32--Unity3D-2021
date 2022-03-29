#include "main.h"
#include "stm32f4xx_it.h"

extern HCD_HandleTypeDef hhcd_USB_OTG_FS;
extern DMA_HandleTypeDef hdma_adc1;
extern DMA_HandleTypeDef hdma_adc2;

void NMI_Handler(void)
{
  while (1)
  {
  } 
}

void HardFault_Handler(void)
{
  while (1)
  {
   
   
  }
}

void MemManage_Handler(void)
{
  while (1)
  {
   
   
  }
}

void BusFault_Handler(void)
{ 
  while (1)
  {
   
   
  }
}

void UsageFault_Handler(void)
{ 
  while (1)
  {
   
   
  }
}

void SVC_Handler(void)
{
 
}

void DebugMon_Handler(void)
{
 
}

void PendSV_Handler(void)
{
 
}

void SysTick_Handler(void)
{ 
  HAL_IncTick();
}

void DMA2_Stream0_IRQHandler(void)
{ 
  HAL_DMA_IRQHandler(&hdma_adc1);
}

void DMA2_Stream2_IRQHandler(void)
{ 
  HAL_DMA_IRQHandler(&hdma_adc2);
}

void OTG_FS_IRQHandler(void)
{ 
  HAL_HCD_IRQHandler(&hhcd_USB_OTG_FS);
}
