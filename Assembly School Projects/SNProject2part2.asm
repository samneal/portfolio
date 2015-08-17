TITLE Program Template           (Template.asm)

; Program Description: Project 2- Part 2
; Author: Sam Neal
; Creation Date: 6/26/2015
; Revisions: 
; Date:  6/26/2015            Modified by:

INCLUDE Irvine32.inc

.data

message1 db "Enter donation from $1 and $5000 (0 to quit): ", 0
message2 db "Class of Donation: ", 0
message3 db "Error: Amount must be between 1 and 5000", 0
plat db "Platinum", 0
gold db "Gold", 0
silver db "Silver", 0
bronze db "Bronze", 0
copper db "Copper", 0

.code
main PROC

pushad
call Clrscr
mov edx, OFFSET message1
call WriteString
call ReadInt
call Crlf

.IF eax > 5000
mov edx, OFFSET message3
call WriteString
jmp quit
.ENDIF

cmp eax, 0
je quit

.IF eax >= 4000
mov al, plat

.ELSEIF eax >= 3000
mov al, gold
.ELSEIF eax >= 2000
mov al, silver
.ELSEIF eax >= 1000
mov al, bronze
.ELSE
mov al, copper
.ENDIF

mov edx, OFFSET message2
call WriteString
call WriteChar
call Crlf

Quit :
popad
ret

exit 
main ENDP
END main