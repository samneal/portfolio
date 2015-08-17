TITLE Project 4 - Sam Neal

Comment !
I am afraid that changing this will break everything.
!
INCLUDE Irvine32.inc

.data
str1 BYTE "Enter your weight in pounds  ",0
str2 BYTE "Enter your height in inches ",0
str3 BYTE "Your converted weight: ",0
str4 BYTE "Your converted height: ",0dh,0ah,0

str5 BYTE "Type the number 703 and press Enter please ",0
str6 BYTE "Your converted height: ", 0
str7 BYTE "Your BMI: ", 0

str8 BYTE "Type the number 18.5 and press Enter ",0
str9 BYTE "Type the number 25 and press Enter ",0
strA BYTE "Type the number 30 and press Enter ",0

under BYTE "You are underweight ",0
normal BYTE "You are a normal weight ",0
over BYTE "You are overweight ",0
obese BYTE "You are obese ",0

space BYTE " ",0



underWeight REAL10 1.85e+1
normalWeight REAL10 2.5e+1
overWeight REAL10 3.0e+1

;BMI = (W * 703) / (H*W)

.code
main PROC

; Input integers from user

L1:	
     ;Get Weight
     mov edx,OFFSET str1
     call WriteString		; display prompt
     call Crlf
     call ReadFloat		; read int from user
     mov edx,OFFSET str3
     call WriteString		; display prompt
     call WriteFloat		; display prompt
    	mov  ecx,eax		; ecx now has the weight
     call Crlf
     call Crlf
    
     mov edx,OFFSET str5
     call WriteString		; display prompt
     call ReadFloat
     FMUL
     call Crlf
     call Crlf


     ;Get Height
     mov edx,OFFSET str2          ;product number
     call WriteString		; display prompt
	call ReadFloat		; read int from user
     FMUL ST(0), ST(0)
     mov edx,OFFSET str4          ;product number
     call WriteString		; display prompt
     call WriteFloat	; display prompt
	mov ebx, eax      ;ebx now has height
     call Crlf
     call Crlf

     FDIV
     mov edx,OFFSET str7         ;product number
     call WriteString		; display prompt
     call WriteFloat
     call Crlf
     call Crlf

     mov edx,OFFSET str8
     call WriteString		; display prompt
     call ReadFloat
     FCOM
     JG L3
     JL L2

     

  L2:
     mov edx,OFFSET under
     call WriteString		; display prompt
     call Crlf
     jmp L9

  L3:
    mov edx,OFFSET str9
    call WriteString		; display prompt
    call ReadFloat
    FCOM
    JG L4
    JL L5
   
L4:
     mov edx,OFFSET normal
     call WriteString		; display prompt
     call Crlf
     jmp L9

L5:
     mov edx,OFFSET strA
     call WriteString		; display prompt
     call ReadFloat
     JG L6
     JL L7
L6:
     mov edx,OFFSET over
     call WriteString		; display prompt
     call Crlf
     jmp L9

L7:
     mov edx,OFFSET obese
     call WriteString		; display prompt
     jmp L9

L9:

	exit
main ENDP
END main