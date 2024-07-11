using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using System.Collections.Frozen;
using System.Threading.Tasks;

namespace IconExplorer;

public sealed partial class SegoeIcons
{
    public SegoeIcons() => InitializeComponent();

    private void UIElement_OnTapped2(object sender, TappedRoutedEventArgs e) => SetItemsSource(ItemSource);

    private int[] ItemSource { get; } =
    [
        0xE001, 0xE002, 0xE003, 0xE004, 0xE005, 0xE006, 0xE007, 0xE008, 0xE009, 0xE00A, 0xE00B, 0xE00C, 0xE00E, 0xE00F,
        0xE010, 0xE011, 0xE012, 0xE013, 0xE014, 0xE015, 0xE016, 0xE017, 0xE018, 0xE019, 0xE052, 0xE07F, 0xE081, 0xE082,
        0xE087, 0xE08F, 0xE094, 0xE096, 0xE097, 0xE098, 0xE099, 0xE09A, 0xE09B, 0xE09C, 0xE09D, 0xE09E, 0xE09F, 0xE0A0,
        0xE0A1, 0xE0A2, 0xE0A5, 0xE0A6, 0xE0AB, 0xE0AD, 0xE0AE, 0xE0B4, 0xE0B5, 0xE0B8, 0xE0C4, 0xE0D5, 0xE0E2, 0xE0E3,
        0xE0E4, 0xE0E5, 0xE0E7, 0xE100, 0xE101, 0xE102, 0xE103, 0xE104, 0xE105, 0xE106, 0xE107, 0xE108, 0xE109, 0xE10A,
        0xE10B, 0xE10C, 0xE10D, 0xE10E, 0xE10F, 0xE110, 0xE111, 0xE112, 0xE113, 0xE114, 0xE115, 0xE116, 0xE117, 0xE118,
        0xE119, 0xE11A, 0xE11B, 0xE11C, 0xE11D, 0xE11E, 0xE11F, 0xE120, 0xE121, 0xE122, 0xE123, 0xE124, 0xE125, 0xE126,
        0xE127, 0xE128, 0xE129, 0xE12A, 0xE12B, 0xE12C, 0xE12D, 0xE12E, 0xE12F, 0xE130, 0xE131, 0xE132, 0xE133, 0xE134,
        0xE135, 0xE136, 0xE137, 0xE138, 0xE139, 0xE13A, 0xE13B, 0xE13C, 0xE13D, 0xE13E, 0xE13F, 0xE140, 0xE141, 0xE142,
        0xE143, 0xE144, 0xE145, 0xE146, 0xE147, 0xE148, 0xE149, 0xE14A, 0xE14B, 0xE14C, 0xE14D, 0xE14E, 0xE14F, 0xE150,
        0xE151, 0xE152, 0xE153, 0xE154, 0xE155, 0xE156, 0xE158, 0xE159, 0xE15A, 0xE15B, 0xE15C, 0xE15D, 0xE15E, 0xE15F,
        0xE160, 0xE161, 0xE162, 0xE163, 0xE164, 0xE165, 0xE166, 0xE167, 0xE168, 0xE169, 0xE16A, 0xE16B, 0xE16C, 0xE16D,
        0xE16E, 0xE16F, 0xE170, 0xE171, 0xE172, 0xE173, 0xE174, 0xE175, 0xE176, 0xE177, 0xE178, 0xE179, 0xE17A, 0xE17B,
        0xE17C, 0xE17D, 0xE181, 0xE182, 0xE183, 0xE184, 0xE185, 0xE186, 0xE187, 0xE188, 0xE189, 0xE18A, 0xE18B, 0xE18C,
        0xE18D, 0xE18E, 0xE18F, 0xE190, 0xE191, 0xE192, 0xE193, 0xE194, 0xE195, 0xE196, 0xE197, 0xE198, 0xE199, 0xE19A,
        0xE19B, 0xE19C, 0xE19D, 0xE19E, 0xE19F, 0xE1A0, 0xE1A1, 0xE1A2, 0xE1A3, 0xE1A4, 0xE1A5, 0xE1A6, 0xE1A7, 0xE1A8,
        0xE1AA, 0xE1AB, 0xE1AC, 0xE1AD, 0xE1AE, 0xE1AF, 0xE1B0, 0xE1B1, 0xE1B2, 0xE1B3, 0xE1B4, 0xE1B5, 0xE1B6, 0xE1B7,
        0xE1B8, 0xE1B9, 0xE1BA, 0xE1BB, 0xE1BC, 0xE1BD, 0xE1BE, 0xE1BF, 0xE1C0, 0xE1C2, 0xE1C3, 0xE1C4, 0xE1C5, 0xE1C6,
        0xE1C7, 0xE1C8, 0xE1C9, 0xE1CA, 0xE1CB, 0xE1CC, 0xE1CD, 0xE1CE, 0xE1CF, 0xE1D0, 0xE1D1, 0xE1D2, 0xE1D3, 0xE1D4,
        0xE1D5, 0xE1D6, 0xE1D7, 0xE1D8, 0xE1D9, 0xE1DA, 0xE1DB, 0xE1DC, 0xE1DD, 0xE1DE, 0xE1DF, 0xE1E0, 0xE1E1, 0xE1E2,
        0xE1E3, 0xE1E4, 0xE1E5, 0xE1E6, 0xE1E7, 0xE1E8, 0xE1E9, 0xE1EA, 0xE1EC, 0xE1ED, 0xE1EE, 0xE1EF, 0xE1F1, 0xE1F2,
        0xE1F3, 0xE1F4, 0xE1F5, 0xE1F6, 0xE1F7, 0xE1FD, 0xE206, 0xE208, 0xE209, 0xE20A, 0xE20B, 0xE211, 0xE212, 0xE224,
        0xE228, 0xE248, 0xE249, 0xE24A, 0xE25A, 0xE25B, 0xE25C, 0xE25D, 0xE25E, 0xE26B, 0xE26C, 0xE28F, 0xE290, 0xE291,
        0xE292, 0xE294, 0xE295, 0xE297, 0xE298, 0xE299, 0xE29B, 0xE2AC, 0xE2AD, 0xE2AE, 0xE2AF, 0xE2B0, 0xE2B1, 0xE2B2,
        0xE2B3, 0xE2B4, 0xE2F6, 0xE2F7, 0xE320, 0xE34D, 0xE361, 0xE363, 0xE37A, 0xE3B3, 0xE3BA, 0xE3BB, 0xE3BC, 0xE3C1,
        0xE3C2, 0xE3C3, 0xE3C4, 0xE3C5, 0xE3C6, 0xE3C7, 0xE3C8, 0xE3C9, 0xE3CA, 0xE3CB, 0xE3D7, 0xE3D8, 0xE407, 0xE408,
        0xE409, 0xE40A, 0xE40B, 0xE40C, 0xE40D, 0xE40E, 0xE40F, 0xE410, 0xE411, 0xE412, 0xE413, 0xE414, 0xE415, 0xE416,
        0xE417, 0xE418, 0xE419, 0xE41A, 0xE41B, 0xE41C, 0xE41D, 0xE425, 0xE44A, 0xE44B, 0xE44C, 0xE44D, 0xE44E, 0xE44F,
        0xE450, 0xE451, 0xE452, 0xE453, 0xE454, 0xE4E8, 0xE5B0, 0xE5B1, 0xE614, 0xE615, 0xE616, 0xE617, 0xE618, 0xE61F,
        0xE620, 0xE621, 0xE622, 0xE623, 0xE624, 0xE625, 0xE626, 0xE627, 0xE628, 0xE629, 0xE62B, 0xE62E, 0xE62F, 0xE630,
        0xE631, 0xE64B, 0xE64C, 0xE64D, 0xE64E, 0xE64F, 0xE650, 0xE651, 0xE652, 0xE653, 0xE654, 0xE655, 0xE656, 0xE65A,
        0xE65B, 0xE65F, 0xE66A, 0xE66B, 0xE66C, 0xE66D, 0xE670, 0xE671, 0xE672, 0xE673, 0xE674, 0xE675, 0xE678, 0xE679,
        0xE67A, 0xE700, 0xE701, 0xE702, 0xE703, 0xE704, 0xE705, 0xE706, 0xE707, 0xE708, 0xE709, 0xE70A, 0xE70B, 0xE70C,
        0xE70D, 0xE70E, 0xE70F, 0xE710, 0xE711, 0xE712, 0xE713, 0xE714, 0xE715, 0xE716, 0xE717, 0xE718, 0xE719, 0xE71A,
        0xE71B, 0xE71C, 0xE71D, 0xE71E, 0xE71F, 0xE720, 0xE721, 0xE722, 0xE723, 0xE724, 0xE725, 0xE726, 0xE727, 0xE728,
        0xE729, 0xE72A, 0xE72B, 0xE72C, 0xE72D, 0xE72E, 0xE730, 0xE731, 0xE733, 0xE734, 0xE735, 0xE736, 0xE737, 0xE738,
        0xE739, 0xE73A, 0xE73B, 0xE73C, 0xE73D, 0xE73E, 0xE73F, 0xE740, 0xE741, 0xE742, 0xE743, 0xE744, 0xE745, 0xE746,
        0xE747, 0xE748, 0xE749, 0xE74A, 0xE74B, 0xE74C, 0xE74D, 0xE74E, 0xE74F, 0xE750, 0xE751, 0xE752, 0xE753, 0xE754,
        0xE755, 0xE756, 0xE759, 0xE75A, 0xE75B, 0xE75C, 0xE75D, 0xE75E, 0xE75F, 0xE760, 0xE761, 0xE762, 0xE763, 0xE764,
        0xE765, 0xE766, 0xE767, 0xE768, 0xE769, 0xE76B, 0xE76C, 0xE76D, 0xE76E, 0xE76F, 0xE770, 0xE771, 0xE772, 0xE773,
        0xE774, 0xE775, 0xE776, 0xE777, 0xE778, 0xE779, 0xE77A, 0xE77B, 0xE77C, 0xE77E, 0xE77F, 0xE780, 0xE781, 0xE783,
        0xE784, 0xE785, 0xE786, 0xE787, 0xE788, 0xE789, 0xE78A, 0xE78B, 0xE78C, 0xE790, 0xE791, 0xE792, 0xE793, 0xE794,
        0xE799, 0xE7A1, 0xE7A5, 0xE7A6, 0xE7A7, 0xE7A8, 0xE7AC, 0xE7AD, 0xE7B3, 0xE7B5, 0xE7B7, 0xE7B8, 0xE7BA, 0xE7BC,
        0xE7BE, 0xE7BF, 0xE7C0, 0xE7C1, 0xE7C2, 0xE7C3, 0xE7C4, 0xE7C5, 0xE7C6, 0xE7C7, 0xE7C8, 0xE7C9, 0xE7DE, 0xE7E3,
        0xE7E6, 0xE7E7, 0xE7E8, 0xE7EA, 0xE7EB, 0xE7EC, 0xE7ED, 0xE7EE, 0xE7EF, 0xE7F0, 0xE7F1, 0xE7F2, 0xE7F3, 0xE7F4,
        0xE7F5, 0xE7F6, 0xE7F7, 0xE7F8, 0xE7F9, 0xE7FA, 0xE7FB, 0xE7FC, 0xE7FD, 0xE802, 0xE803, 0xE804, 0xE805, 0xE806,
        0xE809, 0xE80A, 0xE80B, 0xE80C, 0xE80D, 0xE80F, 0xE811, 0xE812, 0xE813, 0xE814, 0xE815, 0xE816, 0xE819, 0xE81A,
        0xE81B, 0xE81C, 0xE81D, 0xE81E, 0xE81F, 0xE821, 0xE822, 0xE823, 0xE825, 0xE826, 0xE829, 0xE82A, 0xE82B, 0xE82C,
        0xE82D, 0xE82E, 0xE82F, 0xE830, 0xE833, 0xE835, 0xE836, 0xE838, 0xE839, 0xE83A, 0xE83B, 0xE83C, 0xE83D, 0xE83E,
        0xE83F, 0xE840, 0xE841, 0xE842, 0xE843, 0xE844, 0xE845, 0xE846, 0xE847, 0xE848, 0xE849, 0xE84A, 0xE84B, 0xE84C,
        0xE84D, 0xE84E, 0xE84F, 0xE850, 0xE851, 0xE852, 0xE853, 0xE854, 0xE855, 0xE856, 0xE857, 0xE858, 0xE859, 0xE85A,
        0xE85B, 0xE85C, 0xE85D, 0xE85E, 0xE85F, 0xE860, 0xE861, 0xE862, 0xE863, 0xE864, 0xE865, 0xE866, 0xE867, 0xE868,
        0xE869, 0xE86A, 0xE86B, 0xE86C, 0xE86D, 0xE86E, 0xE86F, 0xE870, 0xE871, 0xE872, 0xE873, 0xE874, 0xE875, 0xE876,
        0xE877, 0xE878, 0xE879, 0xE87A, 0xE87B, 0xE87C, 0xE87D, 0xE87E, 0xE87F, 0xE880, 0xE881, 0xE882, 0xE883, 0xE884,
        0xE885, 0xE886, 0xE887, 0xE888, 0xE889, 0xE88A, 0xE88B, 0xE88C, 0xE88D, 0xE88E, 0xE88F, 0xE890, 0xE891, 0xE892,
        0xE893, 0xE894, 0xE895, 0xE896, 0xE897, 0xE898, 0xE899, 0xE89A, 0xE89B, 0xE89C, 0xE89E, 0xE89F, 0xE8A0, 0xE8A1,
        0xE8A2, 0xE8A3, 0xE8A4, 0xE8A5, 0xE8A6, 0xE8A7, 0xE8A8, 0xE8A9, 0xE8AA, 0xE8AB, 0xE8AC, 0xE8AD, 0xE8AE, 0xE8AF,
        0xE8B0, 0xE8B1, 0xE8B2, 0xE8B3, 0xE8B4, 0xE8B5, 0xE8B6, 0xE8B7, 0xE8B8, 0xE8B9, 0xE8BA, 0xE8BB, 0xE8BC, 0xE8BD,
        0xE8BE, 0xE8BF, 0xE8C0, 0xE8C1, 0xE8C2, 0xE8C3, 0xE8C4, 0xE8C5, 0xE8C6, 0xE8C7, 0xE8C8, 0xE8C9, 0xE8CA, 0xE8CB,
        0xE8CC, 0xE8CD, 0xE8CE, 0xE8CF, 0xE8D0, 0xE8D1, 0xE8D2, 0xE8D3, 0xE8D4, 0xE8D5, 0xE8D6, 0xE8D7, 0xE8D8, 0xE8D9,
        0xE8DA, 0xE8DB, 0xE8DC, 0xE8DD, 0xE8DE, 0xE8DF, 0xE8E0, 0xE8E1, 0xE8E2, 0xE8E3, 0xE8E4, 0xE8E5, 0xE8E6, 0xE8E7,
        0xE8E8, 0xE8E9, 0xE8EA, 0xE8EB, 0xE8EC, 0xE8ED, 0xE8EE, 0xE8EF, 0xE8F0, 0xE8F1, 0xE8F2, 0xE8F3, 0xE8F4, 0xE8F5,
        0xE8F6, 0xE8F7, 0xE8F8, 0xE8F9, 0xE8FA, 0xE8FB, 0xE8FC, 0xE8FD, 0xE8FE, 0xE8FF, 0xE902, 0xE904, 0xE905, 0xE906,
        0xE907, 0xE908, 0xE909, 0xE90A, 0xE90B, 0xE90C, 0xE90D, 0xE90E, 0xE90F, 0xE910, 0xE911, 0xE912, 0xE913, 0xE914,
        0xE915, 0xE916, 0xE91B, 0xE91C, 0xE91F, 0xE921, 0xE922, 0xE923, 0xE924, 0xE925, 0xE926, 0xE927, 0xE928, 0xE929,
        0xE92C, 0xE92D, 0xE92E, 0xE92F, 0xE930, 0xE931, 0xE932, 0xE933, 0xE934, 0xE935, 0xE936, 0xE937, 0xE938, 0xE939,
        0xE93C, 0xE93E, 0xE943, 0xE944, 0xE945, 0xE946, 0xE947, 0xE948, 0xE949, 0xE94A, 0xE94B, 0xE94C, 0xE94D, 0xE94E,
        0xE94F, 0xE950, 0xE951, 0xE952, 0xE953, 0xE954, 0xE955, 0xE956, 0xE957, 0xE958, 0xE95A, 0xE95B, 0xE95D, 0xE95E,
        0xE95F, 0xE960, 0xE961, 0xE962, 0xE963, 0xE964, 0xE965, 0xE966, 0xE967, 0xE968, 0xE969, 0xE96A, 0xE96D, 0xE96E,
        0xE96F, 0xE970, 0xE971, 0xE972, 0xE973, 0xE974, 0xE975, 0xE976, 0xE977, 0xE978, 0xE979, 0xE97A, 0xE97B, 0xE97C,
        0xE97D, 0xE97E, 0xE97F, 0xE980, 0xE981, 0xE982, 0xE983, 0xE984, 0xE985, 0xE986, 0xE987, 0xE988, 0xE989, 0xE98A,
        0xE98F, 0xE990, 0xE992, 0xE993, 0xE994, 0xE995, 0xE996, 0xE998, 0xE99A, 0xE9A1, 0xE9A6, 0xE9A8, 0xE9A9, 0xE9AA,
        0xE9AB, 0xE9AC, 0xE9AD, 0xE9AE, 0xE9AF, 0xE9B0, 0xE9B1, 0xE9B2, 0xE9B3, 0xE9B4, 0xE9B5, 0xE9B6, 0xE9B7, 0xE9B8,
        0xE9B9, 0xE9BA, 0xE9BB, 0xE9BC, 0xE9CA, 0xE9CE, 0xE9D2, 0xE9D5, 0xE9D9, 0xE9E9, 0xE9F3, 0xE9F5, 0xE9F9, 0xEA0C,
        0xEA0D, 0xEA14, 0xEA18, 0xEA1F, 0xEA21, 0xEA24, 0xEA35, 0xEA37, 0xEA38, 0xEA39, 0xEA3A, 0xEA3B, 0xEA3C, 0xEA3D,
        0xEA3F, 0xEA40, 0xEA41, 0xEA42, 0xEA43, 0xEA44, 0xEA47, 0xEA48, 0xEA49, 0xEA4A, 0xEA4B, 0xEA4C, 0xEA4E, 0xEA4F,
        0xEA50, 0xEA51, 0xEA52, 0xEA53, 0xEA54, 0xEA55, 0xEA56, 0xEA57, 0xEA58, 0xEA5B, 0xEA5C, 0xEA5E, 0xEA5F, 0xEA60,
        0xEA61, 0xEA62, 0xEA63, 0xEA64, 0xEA65, 0xEA69, 0xEA6A, 0xEA6C, 0xEA79, 0xEA80, 0xEA81, 0xEA82, 0xEA83, 0xEA84,
        0xEA85, 0xEA86, 0xEA89, 0xEA8A, 0xEA8B, 0xEA8C, 0xEA8D, 0xEA8E, 0xEA8F, 0xEA90, 0xEA91, 0xEA92, 0xEA93, 0xEA94,
        0xEA95, 0xEA97, 0xEA98, 0xEA99, 0xEAA1, 0xEAA2, 0xEAA3, 0xEAA4, 0xEAA5, 0xEAA8, 0xEAAE, 0xEABB, 0xEABC, 0xEAC2,
        0xEAC7, 0xEADF, 0xEAFC, 0xEB05, 0xEB0F, 0xEB11, 0xEB3B, 0xEB3C, 0xEB41, 0xEB42, 0xEB44, 0xEB47, 0xEB48, 0xEB49,
        0xEB4A, 0xEB4B, 0xEB4C, 0xEB4D, 0xEB4E, 0xEB4F, 0xEB50, 0xEB51, 0xEB52, 0xEB55, 0xEB56, 0xEB57, 0xEB58, 0xEB59,
        0xEB5A, 0xEB5B, 0xEB5C, 0xEB5D, 0xEB5E, 0xEB5F, 0xEB60, 0xEB61, 0xEB62, 0xEB63, 0xEB66, 0xEB67, 0xEB68, 0xEB77,
        0xEB7E, 0xEB82, 0xEB83, 0xEB84, 0xEB85, 0xEB86, 0xEB87, 0xEB88, 0xEB89, 0xEB8A, 0xEB8B, 0xEB8C, 0xEB8D, 0xEB90,
        0xEB91, 0xEB95, 0xEB96, 0xEB97, 0xEB9D, 0xEB9E, 0xEB9F, 0xEBA0, 0xEBA1, 0xEBA2, 0xEBA3, 0xEBA4, 0xEBA5, 0xEBA6,
        0xEBA7, 0xEBA8, 0xEBA9, 0xEBAA, 0xEBAB, 0xEBAC, 0xEBAD, 0xEBAE, 0xEBAF, 0xEBB0, 0xEBB1, 0xEBB2, 0xEBB3, 0xEBB4,
        0xEBB5, 0xEBB6, 0xEBB7, 0xEBB8, 0xEBB9, 0xEBBA, 0xEBBB, 0xEBBC, 0xEBBD, 0xEBBE, 0xEBBF, 0xEBC0, 0xEBC3, 0xEBC4,
        0xEBC5, 0xEBC6, 0xEBD2, 0xEBD3, 0xEBD4, 0xEBD5, 0xEBD6, 0xEBD7, 0xEBD8, 0xEBD9, 0xEBDA, 0xEBDB, 0xEBDE, 0xEBE6,
        0xEBE7, 0xEBE8, 0xEBFC, 0xEBFD, 0xEBFE, 0xEBFF, 0xEC00, 0xEC02, 0xEC05, 0xEC06, 0xEC07, 0xEC08, 0xEC09, 0xEC0A,
        0xEC0B, 0xEC11, 0xEC12, 0xEC13, 0xEC14, 0xEC15, 0xEC16, 0xEC19, 0xEC1B, 0xEC1E, 0xEC20, 0xEC24, 0xEC25, 0xEC26,
        0xEC27, 0xEC31, 0xEC32, 0xEC34, 0xEC37, 0xEC38, 0xEC39, 0xEC3A, 0xEC3B, 0xEC3C, 0xEC3D, 0xEC3E, 0xEC3F, 0xEC40,
        0xEC41, 0xEC42, 0xEC43, 0xEC44, 0xEC45, 0xEC46, 0xEC47, 0xEC48, 0xEC49, 0xEC4A, 0xEC4E, 0xEC4F, 0xEC50, 0xEC51,
        0xEC52, 0xEC54, 0xEC55, 0xEC56, 0xEC57, 0xEC58, 0xEC59, 0xEC5A, 0xEC5B, 0xEC5C, 0xEC61, 0xEC64, 0xEC6C, 0xEC6D,
        0xEC71, 0xEC72, 0xEC74, 0xEC75, 0xEC76, 0xEC77, 0xEC7A, 0xEC7E, 0xEC7F, 0xEC80, 0xEC81, 0xEC83, 0xEC87, 0xEC88,
        0xEC8A, 0xEC8F, 0xEC91, 0xEC92, 0xEC94, 0xEC9C, 0xECA5, 0xECA7, 0xECAA, 0xECAD, 0xECAF, 0xECB9, 0xECBA, 0xECBB,
        0xECBC, 0xECBD, 0xECBE, 0xECBF, 0xECC4, 0xECC5, 0xECC6, 0xECC8, 0xECC9, 0xECCA, 0xECCB, 0xECCC, 0xECCD, 0xECE4,
        0xECE7, 0xECE8, 0xECE9, 0xECF0, 0xECF1, 0xECF3, 0xED0C, 0xED0D, 0xED0E, 0xED10, 0xED11, 0xED14, 0xED15, 0xED1A,
        0xED1E, 0xED1F, 0xED21, 0xED25, 0xED28, 0xED2A, 0xED2B, 0xED2C, 0xED2D, 0xED2E, 0xED2F, 0xED30, 0xED31, 0xED32,
        0xED33, 0xED35, 0xED39, 0xED3A, 0xED3C, 0xED3D, 0xED41, 0xED42, 0xED43, 0xED44, 0xED47, 0xED4C, 0xED4D, 0xED53,
        0xED54, 0xED55, 0xED56, 0xED57, 0xED58, 0xED59, 0xED5A, 0xED5B, 0xED5C, 0xED5D, 0xED5E, 0xED5F, 0xED60, 0xED61,
        0xED62, 0xED63, 0xED64, 0xED65, 0xED66, 0xED67, 0xEDA2, 0xEDA3, 0xEDA4, 0xEDA5, 0xEDA6, 0xEDA7, 0xEDA8, 0xEDA9,
        0xEDAA, 0xEDAB, 0xEDAC, 0xEDAD, 0xEDAE, 0xEDAF, 0xEDB0, 0xEDB1, 0xEDB3, 0xEDB4, 0xEDB5, 0xEDC6, 0xEDD5, 0xEDD6,
        0xEDD7, 0xEDD8, 0xEDD9, 0xEDDA, 0xEDDB, 0xEDDC, 0xEDE0, 0xEDE1, 0xEDE2, 0xEDE3, 0xEDE4, 0xEDE5, 0xEDFB, 0xEE35,
        0xEE3F, 0xEE40, 0xEE41, 0xEE42, 0xEE43, 0xEE44, 0xEE45, 0xEE47, 0xEE49, 0xEE4A, 0xEE56, 0xEE57, 0xEE63, 0xEE64,
        0xEE65, 0xEE6F, 0xEE71, 0xEE77, 0xEE79, 0xEE7A, 0xEE92, 0xEE93, 0xEE94, 0xEE95, 0xEEA0, 0xEEA1, 0xEEA3, 0xEECA,
        0xEF15, 0xEF16, 0xEF17, 0xEF18, 0xEF19, 0xEF1F, 0xEF20, 0xEF2C, 0xEF2D, 0xEF2E, 0xEF2F, 0xEF31, 0xEF3B, 0xEF3C,
        0xEF3D, 0xEF3E, 0xEF3F, 0xEF40, 0xEF42, 0xEF58, 0xEF60, 0xEF6B, 0xEF90, 0xEFA5, 0xEFA9, 0xEFDA, 0xF000, 0xF003,
        0xF012, 0xF080, 0xF081, 0xF085, 0xF08C, 0xF08D, 0xF08E, 0xF08F, 0xF090, 0xF093, 0xF094, 0xF095, 0xF096, 0xF0AD,
        0xF0AE, 0xF0AF, 0xF0B0, 0xF0B2, 0xF0B3, 0xF0B4, 0xF0B5, 0xF0B6, 0xF0B7, 0xF0B8, 0xF0B9, 0xF0C6, 0xF0C7, 0xF0CA,
        0xF0CB, 0xF0CC, 0xF0CD, 0xF0CE, 0xF0D2, 0xF0D3, 0xF0D5, 0xF0D6, 0xF0D7, 0xF0D8, 0xF0E2, 0xF0E3, 0xF0E4, 0xF0E5,
        0xF0E6, 0xF0E7, 0xF0E8, 0xF0E9, 0xF0EA, 0xF0EB, 0xF0EC, 0xF0ED, 0xF0EE, 0xF0EF, 0xF0F6, 0xF0F7, 0xF0F8, 0xF0F9,
        0xF0FB, 0xF103, 0xF108, 0xF109, 0xF10A, 0xF10B, 0xF10C, 0xF10D, 0xF10E, 0xF110, 0xF111, 0xF112, 0xF117, 0xF119,
        0xF11B, 0xF120, 0xF126, 0xF127, 0xF128, 0xF129, 0xF12A, 0xF12B, 0xF12E, 0xF12F, 0xF131, 0xF133, 0xF136, 0xF137,
        0xF138, 0xF139, 0xF13A, 0xF13B, 0xF13C, 0xF13D, 0xF13E, 0xF13F, 0xF140, 0xF141, 0xF142, 0xF143, 0xF146, 0xF147,
        0xF148, 0xF149, 0xF14A, 0xF14B, 0xF14C, 0xF14D, 0xF14E, 0xF14F, 0xF150, 0xF151, 0xF152, 0xF153, 0xF154, 0xF155,
        0xF156, 0xF157, 0xF158, 0xF159, 0xF15F, 0xF161, 0xF163, 0xF164, 0xF165, 0xF166, 0xF167, 0xF168, 0xF169, 0xF16A,
        0xF16B, 0xF16C, 0xF16D, 0xF16E, 0xF175, 0xF17F, 0xF180, 0xF182, 0xF191, 0xF193, 0xF19D, 0xF19E, 0xF19F, 0xF1AD,
        0xF1B1, 0xF1CB, 0xF1CC, 0xF1D8, 0xF1D9, 0xF1DB, 0xF1E8, 0xF20C, 0xF20D, 0xF210, 0xF211, 0xF22C, 0xF22E, 0xF232,
        0xF246, 0xF259, 0xF260, 0xF261, 0xF26B, 0xF26C, 0xF26D, 0xF26E, 0xF270, 0xF271, 0xF272, 0xF27C, 0xF27F, 0xF285,
        0xF28B, 0xF2A3, 0xF2A5, 0xF2A8, 0xF2B7, 0xF2C7, 0xF2C8, 0xF2D9, 0xF32A, 0xF354, 0xF384, 0xF385, 0xF386, 0xF39B,
        0xF3B1, 0xF3CC, 0xF3CD, 0xF3E2, 0xF3E7, 0xF404, 0xF405, 0xF406, 0xF407, 0xF408, 0xF413, 0xF427, 0xF432, 0xF439,
        0xF45E, 0xF45F, 0xF460, 0xF461, 0xF462, 0xF463, 0xF464, 0xF465, 0xF466, 0xF473, 0xF474, 0xF475, 0xF476, 0xF47F,
        0xF49A, 0xF4A5, 0xF4A9, 0xF4AA, 0xF4BD, 0xF4BE, 0xF4BF, 0xF4C0, 0xF4C3, 0xF540, 0xF552, 0xF56D, 0xF56E, 0xF56F,
        0xF570, 0xF571, 0xF572, 0xF573, 0xF574, 0xF575, 0xF576, 0xF577, 0xF578, 0xF579, 0xF57A, 0xF57B, 0xF57C, 0xF57D,
        0xF57E, 0xF57F, 0xF580, 0xF581, 0xF582, 0xF583, 0xF584, 0xF585, 0xF586, 0xF587, 0xF588, 0xF589, 0xF58A, 0xF58B,
        0xF58C, 0xF58D, 0xF58E, 0xF58F, 0xF590, 0xF591, 0xF592, 0xF593, 0xF594, 0xF595, 0xF596, 0xF597, 0xF598, 0xF599,
        0xF59A, 0xF59B, 0xF59C, 0xF59D, 0xF59E, 0xF59F, 0xF5A0, 0xF5A1, 0xF5A2, 0xF5A3, 0xF5A4, 0xF5A5, 0xF5A6, 0xF5A7,
        0xF5A8, 0xF5A9, 0xF5AA, 0xF5AB, 0xF5AC, 0xF5AD, 0xF5AE, 0xF5B0, 0xF5E7, 0xF5ED, 0xF5EE, 0xF5EF, 0xF5F2, 0xF5F3,
        0xF5F4, 0xF5F5, 0xF5F6, 0xF5F7, 0xF5F8, 0xF5F9, 0xF5FA, 0xF5FB, 0xF5FC, 0xF5FD, 0xF5FE, 0xF5FF, 0xF600, 0xF601,
        0xF602, 0xF603, 0xF604, 0xF605, 0xF606, 0xF607, 0xF608, 0xF618, 0xF619, 0xF61A, 0xF61B, 0xF61C, 0xF61D, 0xF61E,
        0xF61F, 0xF620, 0xF623, 0xF624, 0xF63C, 0xF657, 0xF658, 0xF659, 0xF65A, 0xF65B, 0xF65C, 0xF67B, 0xF683, 0xF684,
        0xF698, 0xF69B, 0xF69E, 0xF6A9, 0xF6B8, 0xF6BA, 0xF6FA, 0xF712, 0xF714, 0xF715, 0xF716, 0xF71A, 0xF71C, 0xF71D,
        0xF71E, 0xF736, 0xF738, 0xF739, 0xF73D, 0xF73E, 0xF73F, 0xF740, 0xF741, 0xF742, 0xF743, 0xF744, 0xF745, 0xF746,
        0xF763, 0xF781, 0xF785, 0xF78A, 0xF78B, 0xF78C, 0xF78D, 0xF7AD, 0xF7AE, 0xF7AF, 0xF7B0, 0xF7B1, 0xF7B2, 0xF7B3,
        0xF7B4, 0xF7B5, 0xF7B6, 0xF7B7, 0xF7B8, 0xF7B9, 0xF7BA, 0xF7BB, 0xF7DB, 0xF7EC, 0xF7ED, 0xF7EE, 0xF809, 0xF83B,
        0xF83D, 0xF83E, 0xF83F, 0xF847, 0xF87B, 0xF87C, 0xF87D, 0xF87E, 0xF89A, 0xF8A5, 0xF8A6, 0xF8AA, 0xF8AB, 0xF8AC,
        0xF8AD, 0xF8AE, 0xF8AF, 0xF8B0, 0xF8B1, 0xF8B2, 0xF8B3, 0xF8C0, 0xF8C1, 0xF8C2, 0xF8C3, 0xF8C4, 0xF8C5, 0xF8C6,
        0xF8C7, 0xF8C8, 0xF8C9, 0xF8CA, 0xF8CB, 0xF8CC
    ];

    private FrozenDictionary<string, int> Table { get; } =
        Enum.GetValues<FontIconSymbols>().ToDictionary(x => x.ToString().ToLower(), x => (int)x).ToFrozenDictionary();

    private async void TextBox_OnTextChanged(TextBox textBox, TextBoxTextChangingEventArgs e)
    {
        await Task.Yield();
        if (textBox.Text is "")
        {
            SetItemsSource(ItemSource);
            return;
        }

        var text = textBox.Text.ToLower();
        if (Table.TryGetValue(text, out var v))
        {
            SetItemsSource([v]);
            return;
        }

        var view = new List<int>();
        await Task.Run(() =>
        {
            foreach (var (key, value) in Table)
                if (key.Contains(text))
                    view.Add(value);
        });
        SetItemsSource(view);
    }

    private void SetItemsSource(IReadOnlyList<int> source) => ItemsView.ItemsSource = source;

    private static string GetGlyph(int value) => ((char)value).ToString();

    public static string GetGlyphSymbol(FontIconSymbols value) => ((char)value).ToString();

    private static string GetTooltip(int i)
    {
        if (Enum.IsDefined((FontIconSymbols)i))
            return ((FontIconSymbols)i).ToString();
        var name = i.ToString("X");
        if (Enum.IsDefined((Symbol)i))
            return (Symbol)i + name;
        return name;
    }

    private static Visibility GetBackgroundVisibility1(int value) =>
        Enum.IsDefined((FontIconSymbols)value) ? Visibility.Visible : Visibility.Collapsed;

    private static Visibility GetBackgroundVisibility2(int value) =>
        Enum.IsDefined((Symbol)value) ? Visibility.Visible : Visibility.Collapsed;
}