################################################################################
# Automatically-generated file. Do not edit!
################################################################################

SHELL := cmd.exe
RM := rm -rf

USER_OBJS :=

LIBS := 
PROJ := 

O_SRCS := 
C_SRCS := 
S_SRCS := 
S_UPPER_SRCS := 
OBJ_SRCS := 
ASM_SRCS := 
PREPROCESSING_SRCS := 
OBJS := 
OBJS_AS_ARGS := 
C_DEPS := 
C_DEPS_AS_ARGS := 
EXECUTABLES := 
OUTPUT_FILE_PATH :=
OUTPUT_FILE_PATH_AS_ARGS :=
AVR_APP_PATH :=$$$AVR_APP_PATH$$$
QUOTE := "
ADDITIONAL_DEPENDENCIES:=
OUTPUT_FILE_DEP:=

# Every subdirectory with source files must be described here
SUBDIRS :=  \
../i2chw/ \
../mpu6050/ \
../uart/


# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS +=  \
../i2chw/twimastertimeout.c \
../main.c \
../mpu6050/mpu6050.c \
../mpu6050/mpu6050dmp6.c \
../uart/uart.c


PREPROCESSING_SRCS += 


ASM_SRCS += 


OBJS +=  \
i2chw/twimastertimeout.o \
main.o \
mpu6050/mpu6050.o \
mpu6050/mpu6050dmp6.o \
uart/uart.o


OBJS_AS_ARGS +=  \
i2chw/twimastertimeout.o \
main.o \
mpu6050/mpu6050.o \
mpu6050/mpu6050dmp6.o \
uart/uart.o


C_DEPS +=  \
i2chw/twimastertimeout.d \
main.d \
mpu6050/mpu6050.d \
mpu6050/mpu6050dmp6.d \
uart/uart.d


C_DEPS_AS_ARGS +=  \
i2chw/twimastertimeout.d \
main.d \
mpu6050/mpu6050.d \
mpu6050/mpu6050dmp6.d \
uart/uart.d


OUTPUT_FILE_PATH +=Code_MPU6050.elf

OUTPUT_FILE_PATH_AS_ARGS +=Code_MPU6050.elf

ADDITIONAL_DEPENDENCIES:=

OUTPUT_FILE_DEP:= ./makedep.mk

# AVR32/GNU C Compiler











i2chw/%.o: ../i2chw/%.c
	@echo Building file: $<
	@echo Invoking: AVR/GNU C Compiler : (AVR_8_bit_GNU_Toolchain_3.4.0_663) 4.6.2
	$(QUOTE)F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-gcc.exe$(QUOTE) -funsigned-char -funsigned-bitfields -I"../i2chw" -I"../mpu6050" -I"../uart"  -O1 -fpack-struct -fshort-enums -g2 -Wall -c -std=gnu99 -MD -MP -MF "$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -MT"$(@:%.o=%.o)"  -mmcu=atmega128   -o"$@" "$<" 
	@echo Finished building: $<

./%.o: .././%.c
	@echo Building file: $<
	@echo Invoking: AVR/GNU C Compiler : (AVR_8_bit_GNU_Toolchain_3.4.0_663) 4.6.2
	$(QUOTE)F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-gcc.exe$(QUOTE) -funsigned-char -funsigned-bitfields -I"../i2chw" -I"../mpu6050" -I"../uart"  -O1 -fpack-struct -fshort-enums -g2 -Wall -c -std=gnu99 -MD -MP -MF "$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -MT"$(@:%.o=%.o)"  -mmcu=atmega128   -o"$@" "$<" 
	@echo Finished building: $<

mpu6050/%.o: ../mpu6050/%.c
	@echo Building file: $<
	@echo Invoking: AVR/GNU C Compiler : (AVR_8_bit_GNU_Toolchain_3.4.0_663) 4.6.2
	$(QUOTE)F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-gcc.exe$(QUOTE) -funsigned-char -funsigned-bitfields -I"../i2chw" -I"../mpu6050" -I"../uart"  -O1 -fpack-struct -fshort-enums -g2 -Wall -c -std=gnu99 -MD -MP -MF "$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -MT"$(@:%.o=%.o)"  -mmcu=atmega128   -o"$@" "$<" 
	@echo Finished building: $<

uart/%.o: ../uart/%.c
	@echo Building file: $<
	@echo Invoking: AVR/GNU C Compiler : (AVR_8_bit_GNU_Toolchain_3.4.0_663) 4.6.2
	$(QUOTE)F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-gcc.exe$(QUOTE) -funsigned-char -funsigned-bitfields -I"../i2chw" -I"../mpu6050" -I"../uart"  -O1 -fpack-struct -fshort-enums -g2 -Wall -c -std=gnu99 -MD -MP -MF "$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -MT"$(@:%.o=%.o)"  -mmcu=atmega128   -o"$@" "$<" 
	@echo Finished building: $<



# AVR32/GNU Preprocessing Assembler



# AVR32/GNU Assembler




ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

# Add inputs and outputs from these tool invocations to the build variables 

# All Target
all: $(OUTPUT_FILE_PATH) $(ADDITIONAL_DEPENDENCIES)

$(OUTPUT_FILE_PATH): $(OBJS) $(USER_OBJS) $(OUTPUT_FILE_DEP)
	@echo Building target: $@
	@echo Invoking: AVR/GNU Linker : (AVR_8_bit_GNU_Toolchain_3.4.0_663) 4.6.2
	$(QUOTE)F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-gcc.exe$(QUOTE) -o$(OUTPUT_FILE_PATH_AS_ARGS) $(OBJS_AS_ARGS) $(USER_OBJS) $(LIBS) -Wl,-Map="Code_MPU6050.map" -Wl,--start-group -Wl,-lm  -Wl,--end-group  -mmcu=atmega128  
	@echo Finished building target: $@
	"F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-objcopy.exe" -O ihex -R .eeprom -R .fuse -R .lock -R .signature  "Code_MPU6050.elf" "Code_MPU6050.hex"
	"F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-objcopy.exe" -j .eeprom  --set-section-flags=.eeprom=alloc,load --change-section-lma .eeprom=0  --no-change-warnings -O ihex "Code_MPU6050.elf" "Code_MPU6050.eep" || exit 0
	"F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-objdump.exe" -h -S "Code_MPU6050.elf" > "Code_MPU6050.lss"
	"F:\Program Files (x86)\Atmel\Atmel Studio 6.0\extensions\Atmel\AVRGCC\3.4.0.65\AVRToolchain\bin\avr-size.exe" "Code_MPU6050.elf"
	





# Other Targets
clean:
	-$(RM) $(OBJS_AS_ARGS)$(C_DEPS_AS_ARGS) $(EXECUTABLES) 
	rm -rf "Code_MPU6050.elf" "Code_MPU6050.a" "Code_MPU6050.hex" "Code_MPU6050.lss" "Code_MPU6050.eep" "Code_MPU6050.map"
	