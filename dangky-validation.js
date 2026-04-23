(function () {
    const $ = (id) => document.getElementById(id);

    const rules = {
        fullname: {
            el: () => $('txtFullname'), err: () => $('errFullname'),
            check: v => (v || '').trim().length >= 4, msg: 'Tên đăng nhập tối thiểu 4 ký tự.'
        },
        email: {
            el: () => $('txtEmail'), err: () => $('errEmail'),
            check: v => /^[^\s@]+@[^\s@]+\.[^\s@]{2,}$/.test(v || ''), msg: 'Email không hợp lệ.'
        },
        phone: {
            el: () => $('txtPhone'), err: () => $('errPhone'),
            check: v => /^(0|\+84)(3|5|7|8|9)\d{8}$/.test((v || '').replace(/\s+/g, '')),
            msg: 'Số điện thoại sai định dạng (0/ +84, đầu 3/5/7/8/9).'
        },
        password: {
            el: () => $('txtPassword'), err: () => $('errPassword'),
            check: v => (v || '').length >= 6, msg: 'Mật khẩu tối thiểu 6 ký tự.'
        },
        confirm: {
            el: () => $('txtConfirmPassword'), err: () => $('errConfirm'),
            check: v => v === (($('txtPassword')?.value) || ''), msg: 'Mật khẩu nhập lại không khớp.'
        }
    };

    function setError(input, label, msg) {
        if (!input || !label) return;
        if (msg) {
            label.innerHTML = msg;
            input.classList.add('invalid');
        } else {
            label.innerHTML = '&nbsp;';   // giữ chỗ, không làm nhảy layout
            input.classList.remove('invalid');
        }
    }

    function bindLive() {
        Object.values(rules).forEach(({ el, err, check, msg }) => {
            const i = el(), l = err(); if (!i || !l) return;
            const run = () => setError(i, l, check(i.value) ? '' : msg);
            i.addEventListener('input', run);
            i.addEventListener('blur', run);
        });
    }

    window.validateRegisterForm = function () {
        // clear trước (nhưng vẫn giữ chỗ)
        Object.values(rules).forEach(({ el, err }) => setError(el(), err(), ''));
        let firstBad = null;

        Object.values(rules).forEach(({ el, err, check, msg }) => {
            const i = el(), ok = check(i.value);
            if (!ok) { setError(i, err(), msg); if (!firstBad) firstBad = i; }
        });

        if (firstBad) {
            firstBad.focus();
            firstBad.scrollIntoView({ behavior: 'smooth', block: 'center' });
            const server = document.getElementById('lblThongBao'); if (server) server.innerHTML = '&nbsp;';
            return false;
        }
        return true;
    };

    if (document.readyState === 'loading') document.addEventListener('DOMContentLoaded', bindLive);
    else bindLive();
})();
