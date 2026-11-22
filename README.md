# M2 DV2: Profiling  
Play Here:  
https://samuel5024.github.io/M2-DV2-Profiling/  

---  

*Changes I made:*  
- Removed DoLoopStuff() and DoOtherStuff() methods
- Got rid of Debug Statements
- Used Renderer & MaterialPropertyBlock to avoid frequent calls 
- Used ID instead of shader property to set the color
- Stored shader properties inside MaterialPropertyBlocks
- Used SetPropertyBlock to apply the new color

---  
Before Profiling:  

![image alt](https://github.com/Samuel5024/M2-DV2-Profiling/blob/a1fd1c28674f85d949ea0ceee19e1df5394b0004/BeforeProfiling.png)  

---  
After Profiling:  

![image alt](https://github.com/Samuel5024/M2-DV2-Profiling/blob/a1fd1c28674f85d949ea0ceee19e1df5394b0004/AfterProfiling.png)
