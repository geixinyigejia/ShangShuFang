var Product = function () {
    var self = this;

    ko.validation.configure({//ko.validation相关配置
        insertMessages: false,//不自动插入错误消息
        errorElementClass: 'errorElementClass',/*元素的ＣＳＳ样式*/
        errorMessageClass: 'errorMessageClass',/*提示信息ＣＳＳ的样式*/
    });

    self.name = ko.observable().extend({
        minLength: 2,
        maxLength: { params: 30, message: "名称最大长度为30个字符" },
        required: {
            params: true,
            message: "请输入名称",
        }
    });
    self.selName = ko.observable(false);

    self.phone = ko.observable().extend({
        required: true,
        number: {
            params: true,
            message: "电话不合法",
        }
    });
    self.selPhone = ko.observable(false);

    self.Email = ko.observable().extend({
        required: {
            params: true,
            message: "请填写Email"
        },
        email: {
            params: true,
            message: "Email格式不正确"
        }
    });
    self.selEmail = ko.observable(false);

    self.Register = function () {
        self.errors = ko.validation.group(self);
        if (self.isValid()) {
            alert("验证成功，数据可以提交");
        } else {

            self.errors.showAllMessages();
        }
    };
};
product = new Product();
ko.applyBindings(product);