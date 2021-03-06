$managedDatablockSet = new SimSet() {
   canSaveDynamicFields = "1";
      setType = "Datablocks";

   new t2dImageMapDatablock(backgroundImage) {
      imageName = "~/data/images/background.dds";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "1";
      cellCountY = "1";
      cellWidth = "683";
      cellHeight = "512";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
         canSaveDynamicFields = "1";
   };
   new t2dImageMapDatablock(rocksfarImage) {
      imageName = "~/data/images/rocksfar.dds";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
         canSaveDynamicFields = "1";
   };
   new t2dImageMapDatablock(rocksnearImage) {
      imageName = "~/data/images/rocksnear.dds";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
         canSaveDynamicFields = "1";
   };
   new t2dImageMapDatablock(seahorse2sheetImageMap) {
      imageName = "~/data/images/seahorse2sheet.dds";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "128";
      cellHeight = "256";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
         canSaveDynamicFields = "1";
   };
   new t2dAnimationDatablock(seahorse2sheetImageMapAnimation) {
      imageMap = "seahorse2sheetImageMap";
      animationFrames = "0 1 2 3 2 1";
      animationTime = "0.5";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
         canSaveDynamicFields = "1";
   };
};
