/*
 * Copyright (c) 2016, Freescale Semiconductor, Inc.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 *
 * o Redistributions of source code must retain the above copyright notice, this list
 *   of conditions and the following disclaimer.
 *
 * o Redistributions in binary form must reproduce the above copyright notice, this
 *   list of conditions and the following disclaimer in the documentation and/or
 *   other materials provided with the distribution.
 *
 * o Neither the name of Freescale Semiconductor, Inc. nor the names of its
 *   contributors may be used to endorse or promote products derived from this
 *   software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 */

/*
 * TEXT BELOW IS USED AS SETTING FOR THE PINS TOOL *****************************
PinsProfile:
- !!product 'Pins v2.0'
- !!processor 'MKV30F128xxx10'
- !!package 'MKV30F128VLF10'
- !!mcu_data 'ksdk2_0'
- !!processor_version '1.1.0'
- pin_labels:
  - {pin_num: '21', pin_signal: PTA4/LLWU_P3/FTM0_CH1/FTM0_FLT3/NMI_b, label: servo1PWM}
  - {pin_num: '38', pin_signal: PTC5/LLWU_P9/SPI0_SCK/LPTMR0_ALT2/CMP0_OUT/FTM0_CH2, label: servo2PWM}
  - {pin_num: '37', pin_signal: PTC4/LLWU_P8/SPI0_PCS0/UART1_TX/FTM0_CH3/CMP1_OUT, label: servo3PWM}
  - {pin_num: '45', pin_signal: PTD4/LLWU_P14/SPI0_PCS1/UART0_RTS_b/FTM0_CH4/FTM2_CH0/EWM_IN, label: servo4PWM}
  - {pin_num: '46', pin_signal: ADC0_SE6b/PTD5/SPI0_PCS2/UART0_CTS_b/FTM0_CH5/FTM2_CH1/EWM_OUT_b, label: servo5PWM}
  - {pin_num: '25', pin_signal: XTAL0/PTA19/FTM0_FLT0/FTM1_FLT0/FTM_CLKIN1/LPTMR0_ALT1, label: PWRLED, identifier: PWRLED_ID}
  - {pin_num: '39', pin_signal: CMP0_IN0/PTC6/LLWU_P10/SPI0_SOUT/PDB0_EXTRG/UART0_RX/I2C0_SCL, label: userLED1}
  - {pin_num: '40', pin_signal: CMP0_IN1/PTC7/SPI0_SIN/UART0_TX/I2C0_SDA, label: userLED2}
  - {pin_num: '17', pin_signal: PTA0/UART0_CTS_b/FTM0_CH5/EWM_IN/JTAG_TCLK/SWD_CLK, label: servo4PWM}
 * BE CAREFUL MODIFYING THIS COMMENT - IT IS YAML SETTINGS FOR THE PINS TOOL ***
 */

#include "fsl_common.h"
#include "fsl_port.h"
#include "pin_mux.h"

#define PIN0_IDX                         0u   /*!< Pin number for pin 0 in a port */
#define PIN1_IDX                         1u   /*!< Pin number for pin 1 in a port */
#define PIN2_IDX                         2u   /*!< Pin number for pin 2 in a port */
#define PIN3_IDX                         3u   /*!< Pin number for pin 3 in a port */
#define PIN24_IDX                       24u   /*!< Pin number for pin 24 in a port */
#define PIN25_IDX                       25u   /*!< Pin number for pin 25 in a port */
#define SOPT8_FTM0OCH0SRC_FTM         0x00u   /*!< FTM0 channel 0 output source: FTM0_CH0 pin is output of FTM0 channel 0 output */
#define SOPT8_FTM0OCH1SRC_FTM         0x00u   /*!< FTM0 channel 1 output source: FTM0_CH1 pin is output of FTM0 channel 1 output */
#define SOPT8_FTM0OCH2SRC_FTM         0x00u   /*!< FTM0 channel 2 output source: FTM0_CH2 pin is output of FTM0 channel 2 output */
#define SOPT8_FTM0OCH5SRC_FTM         0x00u   /*!< FTM0 channel 5 output source: FTM0_CH5 pin is output of FTM0 channel 5 output */

/*
 * TEXT BELOW IS USED AS SETTING FOR THE PINS TOOL *****************************
BOARD_InitPins:
- options: {coreID: singlecore, enableClock: 'true'}
- pin_list:
  - {pin_num: '12', peripheral: SUPPLY, signal: 'pwr_vssa, 0', pin_signal: VSSA}
  - {pin_num: '1', peripheral: SUPPLY, signal: 'VDD, 0', pin_signal: VDD1}
  - {pin_num: '22', peripheral: SUPPLY, signal: 'VDD, 1', pin_signal: VDD22}
  - {pin_num: '9', peripheral: SUPPLY, signal: 'VDDA, 0', pin_signal: VDDA}
  - {pin_num: '2', peripheral: SUPPLY, signal: 'VSS, 0', pin_signal: VSS2}
  - {pin_num: '23', peripheral: SUPPLY, signal: 'VSS, 1', pin_signal: VSS23}
  - {pin_num: '41', peripheral: SPI0, signal: PCS0_SS, pin_signal: PTD0/LLWU_P12/SPI0_PCS0/UART0_RTS_b/FTM0_CH0/UART1_RX}
  - {pin_num: '42', peripheral: SPI0, signal: SCK, pin_signal: ADC0_SE5b/PTD1/SPI0_SCK/UART0_CTS_b/FTM0_CH1/UART1_TX}
  - {pin_num: '26', peripheral: RCM, signal: RESET, pin_signal: RESET_b}
  - {pin_num: '44', peripheral: SPI0, signal: SIN, pin_signal: PTD3/SPI0_SIN/UART0_TX/FTM0_CH3/I2C0_SDA}
  - {pin_num: '43', peripheral: SPI0, signal: SOUT, pin_signal: PTD2/LLWU_P13/SPI0_SOUT/UART0_RX/FTM0_CH2/I2C0_SCL}
  - {pin_num: '17', peripheral: FTM0, signal: 'CH, 5', pin_signal: PTA0/UART0_CTS_b/FTM0_CH5/EWM_IN/JTAG_TCLK/SWD_CLK, direction: OUTPUT}
  - {pin_num: '16', peripheral: FTM0, signal: 'CH, 1', pin_signal: ADC0_SE18/PTE25/FTM0_CH1/I2C0_SDA/EWM_IN, direction: OUTPUT}
  - {pin_num: '36', peripheral: FTM0, signal: 'CH, 2', pin_signal: CMP1_IN1/PTC3/LLWU_P7/SPI0_PCS1/UART1_RX/FTM0_CH2/CLKOUT, direction: OUTPUT}
  - {pin_num: '15', peripheral: FTM0, signal: 'CH, 0', pin_signal: ADC0_SE17/PTE24/FTM0_CH0/I2C0_SCL/EWM_OUT_b, direction: OUTPUT}
  - {pin_num: '11', peripheral: ADC0, signal: VREFL, pin_signal: VREFL}
  - {pin_num: '10', peripheral: ADC0, signal: VREFH, pin_signal: VREFH}
  - {pin_num: '11', peripheral: ADC1, signal: VREFL, pin_signal: VREFL}
  - {pin_num: '10', peripheral: ADC1, signal: VREFH, pin_signal: VREFH}
 * BE CAREFUL MODIFYING THIS COMMENT - IT IS YAML SETTINGS FOR THE PINS TOOL ***
 */

/*FUNCTION**********************************************************************
 *
 * Function Name : BOARD_InitPins
 * Description   : Configures pin routing and optionally pin electrical features.
 *
 *END**************************************************************************/
void BOARD_InitPins(void) {
  CLOCK_EnableClock(kCLOCK_PortA);                           /* Port A Clock Gate Control: Clock enabled */
  CLOCK_EnableClock(kCLOCK_PortC);                           /* Port C Clock Gate Control: Clock enabled */
  CLOCK_EnableClock(kCLOCK_PortD);                           /* Port D Clock Gate Control: Clock enabled */
  CLOCK_EnableClock(kCLOCK_PortE);                           /* Port E Clock Gate Control: Clock enabled */

  PORT_SetPinMux(PORTA, PIN0_IDX, kPORT_MuxAlt3);            /* PORTA0 (pin 17) is configured as FTM0_CH5 */
  PORT_SetPinMux(PORTC, PIN3_IDX, kPORT_MuxAlt4);            /* PORTC3 (pin 36) is configured as FTM0_CH2 */
  PORT_SetPinMux(PORTD, PIN0_IDX, kPORT_MuxAlt2);            /* PORTD0 (pin 41) is configured as SPI0_PCS0 */
  PORT_SetPinMux(PORTD, PIN1_IDX, kPORT_MuxAlt2);            /* PORTD1 (pin 42) is configured as SPI0_SCK */
  PORT_SetPinMux(PORTD, PIN2_IDX, kPORT_MuxAlt2);            /* PORTD2 (pin 43) is configured as SPI0_SOUT */
  PORT_SetPinMux(PORTD, PIN3_IDX, kPORT_MuxAlt2);            /* PORTD3 (pin 44) is configured as SPI0_SIN */
  PORT_SetPinMux(PORTE, PIN24_IDX, kPORT_MuxAlt3);           /* PORTE24 (pin 15) is configured as FTM0_CH0 */
  PORT_SetPinMux(PORTE, PIN25_IDX, kPORT_MuxAlt3);           /* PORTE25 (pin 16) is configured as FTM0_CH1 */
  SIM->SOPT8 = ((SIM->SOPT8 &
    (~(SIM_SOPT8_FTM0OCH0SRC_MASK | SIM_SOPT8_FTM0OCH1SRC_MASK | SIM_SOPT8_FTM0OCH2SRC_MASK | SIM_SOPT8_FTM0OCH5SRC_MASK))) /* Mask bits to zero which are setting */
      | SIM_SOPT8_FTM0OCH0SRC(SOPT8_FTM0OCH0SRC_FTM)         /* FTM0 channel 0 output source: FTM0_CH0 pin is output of FTM0 channel 0 output */
      | SIM_SOPT8_FTM0OCH1SRC(SOPT8_FTM0OCH1SRC_FTM)         /* FTM0 channel 1 output source: FTM0_CH1 pin is output of FTM0 channel 1 output */
      | SIM_SOPT8_FTM0OCH2SRC(SOPT8_FTM0OCH2SRC_FTM)         /* FTM0 channel 2 output source: FTM0_CH2 pin is output of FTM0 channel 2 output */
      | SIM_SOPT8_FTM0OCH5SRC(SOPT8_FTM0OCH5SRC_FTM)         /* FTM0 channel 5 output source: FTM0_CH5 pin is output of FTM0 channel 5 output */
    );
}

/*******************************************************************************
 * EOF
 ******************************************************************************/
