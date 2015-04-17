# Copyright(c)2015 Matheus Silva
# MakeFile generator take some input and generate a MakeFile

makeFileGen =
    core: () ->
      inputFile = arguments[0] or "../makefile"
      
