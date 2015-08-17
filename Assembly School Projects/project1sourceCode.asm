TITLE Program Template           (Template.asm)

; Program Description: Project 1
; Author: Sam Neal
; Creation Date: 6/15/2015
; Revisions: 
; Date:  6/15/2015            Modified by:

INCLUDE Irvine32.inc
.data
	; (insert variables here)
	message BYTE "Hello world!",0
	left DWORD 297
	right DWORD 0122
	total DWORD ?
	diff DWORD ?
	Array WORD 1,2,4,8,16,32,64
	ArrayLength = ($ - Array) / 2

.code
main PROC
	; (insert executable instructions here)
	mov eax, left
	add eax, right
	mov ebx, left
	sub ebx, right
	mov diff, ebx
	mov total, eax
	mov ecx, total
	mov edx, diff
	mov eax, left
	mov ebx, right
	mov esi, ArrayLength
	call DumpRegs
	exit
main ENDP
	; (insert additional procedures here)
END main