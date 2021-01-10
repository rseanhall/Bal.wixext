@setlocal
@pushd %~dp0
@set _C=Release

nuget restore || exit /b

msbuild -p:Configuration=%_C% -Restore || exit /b
msbuild -p:Configuration=%_C% src\test\examples\examples.proj || exit /b

dotnet test -c %_C% --no-build src\test\WixToolsetTest.ManagedHost || exit /b

@popd
@endlocal
