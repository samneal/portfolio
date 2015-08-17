TITLE Program Template           (Template.asm)

; Program Description: Project 2
; Author: Sam Neal
; Creation Date: 6/26/2015
; Revisions: 
; Date:  6/26/2015            Modified by:

INCLUDE Irvine32.inc
.data
Array DWORD 3,1,4,1,5,9,2,6,5,3,5,8,9,7,9,3,2,3,8,4
lower DWORD 3
upper DWORD 8
ArraySize = ($ - Array)-11 ;/ TYPE Array
index DWORD 0
sum DWORD 0
counter DWORD 0

.code
main PROC

    mov eax, 0           ; sum
    mov edx, lower
    mov esi, 0          ; index
    mov ebx, upper
    mov ax, 0
    mov ecx, ArraySize
    mov edi, Array[esi]  ;Register containing value of array element
    

L1: 
cmp esi,ecx 
    jl  L2
    jmp L5
    
L2: mov edi, Array[esi]    ;start of if statement
    
    cmp edi, edx 
    jge  L6
    jmp L4
   
L3: add eax, array[esi]

L4: add esi, 4
    jmp L1

L5: mov sum, eax
    jmp l8

l6: cmp edi, ebx     ;part 2 of if statement
    jge L7
    add eax, edi
    add ax, 1
    
    jmp L7

l7: add esi, 4
    jmp L1

l8:
;sum
;call DumpRegs


    exit
main ENDP
END main

;Help- I could not for the life of me figure out how to output the value of a single register. 