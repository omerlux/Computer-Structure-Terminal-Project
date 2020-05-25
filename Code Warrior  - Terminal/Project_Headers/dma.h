
#ifndef DMA_H_
#define DMA_H_

#include "derivative.h"
//#include "pit.h"

#define  ADC_READS 1000      		//1000 medidot
extern uint16_t  value[ADC_READS];
extern CurrSize;

void DMA0_Init_toNaveh(void);
void DMA1_Init_toPC(void);
void DMA0_IRQHandler(void);
void DMA1_IRQHandler(void);

#endif /* DMA_H_ */
