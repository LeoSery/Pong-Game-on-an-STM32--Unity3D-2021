#ifndef __STM32F4xx_H
#define __STM32F4xx_H

#ifdef __cplusplus
 extern "C" {
#endif

#if !defined  (STM32F4)
#define STM32F4
#endif


#if !defined (STM32F405xx) && !defined (STM32F415xx) && !defined (STM32F407xx) && !defined (STM32F417xx) && \
    !defined (STM32F427xx) && !defined (STM32F437xx) && !defined (STM32F429xx) && !defined (STM32F439xx) && \
    !defined (STM32F401xC) && !defined (STM32F401xE) && !defined (STM32F410Tx) && !defined (STM32F410Cx) && \
    !defined (STM32F410Rx) && !defined (STM32F411xE) && !defined (STM32F446xx) && !defined (STM32F469xx) && \
    !defined (STM32F479xx) && !defined (STM32F412Cx) && !defined (STM32F412Rx) && !defined (STM32F412Vx) && \
    !defined (STM32F412Zx) && !defined (STM32F413xx) && !defined (STM32F423xx)
   
#endif
   
#if !defined  (USE_HAL_DRIVER)
 
#endif

#define __STM32F4xx_CMSIS_VERSION_MAIN   (0x02U)
#define __STM32F4xx_CMSIS_VERSION_SUB1   (0x06U)
#define __STM32F4xx_CMSIS_VERSION_SUB2   (0x07U)
#define __STM32F4xx_CMSIS_VERSION_RC     (0x00U)
#define __STM32F4xx_CMSIS_VERSION        ((__STM32F4xx_CMSIS_VERSION_MAIN << 24)\
                                         |(__STM32F4xx_CMSIS_VERSION_SUB1 << 16)\
                                         |(__STM32F4xx_CMSIS_VERSION_SUB2 << 8 )\
                                         |(__STM32F4xx_CMSIS_VERSION_RC))

#if defined(STM32F405xx)
  #include "stm32f405xx.h"
#elif defined(STM32F415xx)
  #include "stm32f415xx.h"
#elif defined(STM32F407xx)
  #include "stm32f407xx.h"
#elif defined(STM32F417xx)
  #include "stm32f417xx.h"
#elif defined(STM32F427xx)
  #include "stm32f427xx.h"
#elif defined(STM32F437xx)
  #include "stm32f437xx.h"
#elif defined(STM32F429xx)
  #include "stm32f429xx.h"
#elif defined(STM32F439xx)
  #include "stm32f439xx.h"
#elif defined(STM32F401xC)
  #include "stm32f401xc.h"
#elif defined(STM32F401xE)
  #include "stm32f401xe.h"
#elif defined(STM32F410Tx)
  #include "stm32f410tx.h"
#elif defined(STM32F410Cx)
  #include "stm32f410cx.h"
#elif defined(STM32F410Rx)
  #include "stm32f410rx.h"
#elif defined(STM32F411xE)
  #include "stm32f411xe.h"
#elif defined(STM32F446xx)
  #include "stm32f446xx.h"
#elif defined(STM32F469xx)
  #include "stm32f469xx.h"
#elif defined(STM32F479xx)
  #include "stm32f479xx.h"
#elif defined(STM32F412Cx)
  #include "stm32f412cx.h"
#elif defined(STM32F412Zx)
  #include "stm32f412zx.h"
#elif defined(STM32F412Rx)
  #include "stm32f412rx.h"
#elif defined(STM32F412Vx)
  #include "stm32f412vx.h"
#elif defined(STM32F413xx)
  #include "stm32f413xx.h"
#elif defined(STM32F423xx)
  #include "stm32f423xx.h"
#else
 #error "Please select first the target STM32F4xx device used in your application (in stm32f4xx.h file)"
#endif
 
typedef enum 
{
  RESET = 0U, 
  SET = !RESET
} FlagStatus, ITStatus;

typedef enum 
{
  DISABLE = 0U, 
  ENABLE = !DISABLE
} FunctionalState;
#define IS_FUNCTIONAL_STATE(STATE) (((STATE) == DISABLE) || ((STATE) == ENABLE))

typedef enum
{
  SUCCESS = 0U,
  ERROR = !SUCCESS
} ErrorStatus;

#define SET_BIT(REG, BIT)     ((REG) |= (BIT))

#define CLEAR_BIT(REG, BIT)   ((REG) &= ~(BIT))

#define READ_BIT(REG, BIT)    ((REG) & (BIT))

#define CLEAR_REG(REG)        ((REG) = (0x0))

#define WRITE_REG(REG, VAL)   ((REG) = (VAL))

#define READ_REG(REG)         ((REG))

#define MODIFY_REG(REG, CLEARMASK, SETMASK)  WRITE_REG((REG), (((READ_REG(REG)) & (~(CLEARMASK))) | (SETMASK)))

#define POSITION_VAL(VAL)     (__CLZ(__RBIT(VAL))) 

#define ATOMIC_SET_BIT(REG, BIT)                             \
  do {                                                       \
    uint32_t val;                                            \
    do {                                                     \
      val = __LDREXW((__IO uint32_t *)&(REG)) | (BIT);       \
    } while ((__STREXW(val,(__IO uint32_t *)&(REG))) != 0U); \
  } while(0)

#define ATOMIC_CLEAR_BIT(REG, BIT)                           \
  do {                                                       \
    uint32_t val;                                            \
    do {                                                     \
      val = __LDREXW((__IO uint32_t *)&(REG)) & ~(BIT);      \
    } while ((__STREXW(val,(__IO uint32_t *)&(REG))) != 0U); \
  } while(0)

#define ATOMIC_MODIFY_REG(REG, CLEARMSK, SETMASK)                          \
  do {                                                                     \
    uint32_t val;                                                          \
    do {                                                                   \
      val = (__LDREXW((__IO uint32_t *)&(REG)) & ~(CLEARMSK)) | (SETMASK); \
    } while ((__STREXW(val,(__IO uint32_t *)&(REG))) != 0U);               \
  } while(0)

#define ATOMIC_SETH_BIT(REG, BIT)                            \
  do {                                                       \
    uint16_t val;                                            \
    do {                                                     \
      val = __LDREXH((__IO uint16_t *)&(REG)) | (BIT);       \
    } while ((__STREXH(val,(__IO uint16_t *)&(REG))) != 0U); \
  } while(0)

#define ATOMIC_CLEARH_BIT(REG, BIT)                          \
  do {                                                       \
    uint16_t val;                                            \
    do {                                                     \
      val = __LDREXH((__IO uint16_t *)&(REG)) & ~(BIT);      \
    } while ((__STREXH(val,(__IO uint16_t *)&(REG))) != 0U); \
  } while(0)

#define ATOMIC_MODIFYH_REG(REG, CLEARMSK, SETMASK)                         \
  do {                                                                     \
    uint16_t val;                                                          \
    do {                                                                   \
      val = (__LDREXH((__IO uint16_t *)&(REG)) & ~(CLEARMSK)) | (SETMASK); \
    } while ((__STREXH(val,(__IO uint16_t *)&(REG))) != 0U);               \
  } while(0)

#if defined (USE_HAL_DRIVER)
 #include "stm32f4xx_hal.h"
#endif

#ifdef __cplusplus
}
#endif

#endif
