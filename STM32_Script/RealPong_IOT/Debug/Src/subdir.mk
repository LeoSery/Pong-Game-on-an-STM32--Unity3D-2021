################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Src/main.c \
../Src/stm32f4xx_hal_msp.c \
../Src/stm32f4xx_it.c \
../Src/syscalls.c \
../Src/system_stm32f4xx.c \
../Src/usb_host.c \
../Src/usbh_conf.c \
../Src/usbh_platform.c 

OBJS += \
./Src/main.o \
./Src/stm32f4xx_hal_msp.o \
./Src/stm32f4xx_it.o \
./Src/syscalls.o \
./Src/system_stm32f4xx.o \
./Src/usb_host.o \
./Src/usbh_conf.o \
./Src/usbh_platform.o 

C_DEPS += \
./Src/main.d \
./Src/stm32f4xx_hal_msp.d \
./Src/stm32f4xx_it.d \
./Src/syscalls.d \
./Src/system_stm32f4xx.d \
./Src/usb_host.d \
./Src/usbh_conf.d \
./Src/usbh_platform.d 


# Each subdirectory must supply rules for building sources it contributes
Src/%.o: ../Src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m4 -mthumb -mfloat-abi=hard -mfpu=fpv4-sp-d16 -DUSE_HAL_DRIVER -DSTM32F407xx -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Inc" -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Drivers/STM32F4xx_HAL_Driver/Inc" -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Drivers/STM32F4xx_HAL_Driver/Inc/Legacy" -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Middlewares/ST/STM32_USB_Host_Library/Core/Inc" -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Middlewares/ST/STM32_USB_Host_Library/Class/CDC/Inc" -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Drivers/CMSIS/Device/ST/STM32F4xx/Include" -I"D:/Ynov/B2/IOT/Projets/RealPong_IOT/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


