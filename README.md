# bprd

To  compile using FsYacc and FsLex, edit the project file and include the following, but change names as needed:

```XML
	<ItemGroup>
        <FsYacc Include="ExprPar.fsy">
            <OtherFlags>--module ExprPar</OtherFlags>
        </FsYacc>
        <FsLex Include="ExprLex.fsl">
            <OtherFlags> --unicode</OtherFlags>
        </FsLex>
    </ItemGroup>
```

Full example in Assignment 2